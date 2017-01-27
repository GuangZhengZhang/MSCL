/*******************************************************************************
Copyright(c) 2015-2017 LORD Corporation. All rights reserved.

MIT Licensed. See the included LICENSE.txt for a copy of the full MIT License.
*******************************************************************************/
#include "stdafx.h"
#include "LongPing.h"
#include "WirelessProtocol.h"
#include "mscl/MicroStrain/ByteStream.h"
#include "mscl/MicroStrain/Wireless/Packets/WirelessPacket.h"


namespace mscl
{
    PingResponse::PingResponse() :
        m_success(false),
        m_nodeRssi(WirelessTypes::UNKNOWN_RSSI),
        m_baseRssi(WirelessTypes::UNKNOWN_RSSI)
    {
    }

    PingResponse::PingResponse(bool success, int16 nodeRssi, int16 baseRssi):
        m_success(success),
        m_nodeRssi(nodeRssi),
        m_baseRssi(baseRssi)
    {
    }

    PingResponse PingResponse::ResponseSuccess(int16 nodeRssi, int16 baseRssi)
    {
        return PingResponse(true, nodeRssi, baseRssi);
    }

    PingResponse PingResponse::ResponseFail()
    {
        return PingResponse(false, WirelessTypes::UNKNOWN_RSSI, WirelessTypes::UNKNOWN_RSSI);
    }

    bool PingResponse::success() const
    {
        return m_success;
    }

    int16 PingResponse::nodeRssi() const
    {
        return m_nodeRssi;
    }

    int16 PingResponse::baseRssi() const
    {
        return m_baseRssi;
    }




    ByteStream LongPing::buildCommand(NodeAddress nodeAddress)
    {
        //build the command ByteStream
        ByteStream cmd;
        cmd.append_uint8(0xAA);                                     //Start of Packet
        cmd.append_uint8(0x05);                                     //Delivery Stop Flag
        cmd.append_uint8(0x00);                                     //App Data Type
        cmd.append_uint16(nodeAddress);                             //Node address    (2 bytes)
        cmd.append_uint8(0x02);                                     //Payload length
        cmd.append_uint16(WirelessProtocol::cmdId_longPing);        //Command ID    (2 bytes)

        //calculate the checksum of bytes 2-8
        uint16 checksum = cmd.calculateSimpleChecksum(1, 7);

        cmd.append_uint16(checksum);        //Checksum        (2 bytes)

        return cmd;
    }

    LongPing::Response::Response(NodeAddress nodeAddress, std::weak_ptr<ResponseCollector> collector):
        ResponsePattern(collector),
        m_nodeAddress(nodeAddress),
        m_result(PingResponse::ResponseFail())
    {
    }

    bool LongPing::Response::match(const WirelessPacket& packet)
    {
        WirelessPacket::Payload payload = packet.payload();

        //check the main bytes of the packet
        if( packet.deliveryStopFlags().toInvertedByte() != 0x07 ||    //delivery stop flag
            packet.type() != 0x02 ||                                  //app data type
            packet.nodeAddress() != m_nodeAddress ||                  //node address
            payload.size() != 0x02 ||                                 //payload length
            payload.read_uint16(0) != 0x0000
            )            
        {
            //failed to match some of the bytes
            return false;
        }

        //if we made it here, the packet matches the response pattern

        //store the node and base RSSI values with the PingResponse
        m_result = PingResponse::ResponseSuccess(packet.nodeRSSI(), packet.baseRSSI());

        //we have fully matched the response
        m_fullyMatched = true;

        //notify that the response was matched
        m_matchCondition.notify();

        m_success = true;

        return true;
    }

    PingResponse LongPing::Response::result()
    {
        return m_result;
    }
}