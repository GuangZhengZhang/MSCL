/*******************************************************************************
Copyright(c) 2015-2017 LORD Corporation. All rights reserved.

MIT Licensed. See the included LICENSE.txt for a copy of the full MIT License.
*******************************************************************************/
#include "stdafx.h"
#include "InertialNode.h"

#include "mscl/Types.h"
#include "mscl/Communication/SerialConnection.h"
#include "mscl/MicroStrain/Inertial/Commands/Inertial_Commands.h"
#include "Features/InertialNodeFeatures.h"
#include "Packets/InertialPacket.h"
#include "InertialParser.h"
#include "InertialNode_Impl.h"

#include <algorithm>


namespace mscl
{
    InertialNode::InertialNode(Connection connection): 
        m_impl(std::make_shared<InertialNode_Impl>(connection))
    {
    }

    InertialNode::InertialNode(std::shared_ptr<InertialNode_Impl> impl) :
        m_impl(impl)
    {
    }

    const InertialNodeInfo& InertialNode::info()
    {
        return m_impl->info();
    }

    const InertialNodeFeatures& InertialNode::features()
    {
        return m_impl->features();
    }

    InertialDataPackets InertialNode::getDataPackets(uint32 timeout, uint32 maxPackets)                        
    { 
        InertialDataPackets packets;
        m_impl->getDataPackets(packets, timeout, maxPackets);
        return packets;
    }

    std::string InertialNode::deviceName(const std::string& serial)
    {
        //replace any unsupported sensorcloud characters
        std::string sensorcloudFilteredName = "inertial-" + serial;
        Utils::filterSensorcloudName(sensorcloudFilteredName);

        return sensorcloudFilteredName;
    }

    const Timestamp& InertialNode::lastCommunicationTime() const
    {
        return m_impl->lastCommunicationTime();
    }

    const SampleRates& InertialNode::supportedSampleRates(InertialTypes::InertialCategory type)
    { 
        return m_impl->supportedSampleRates(type); 
    }

    uint32 InertialNode::totalPackets()                                                            
    { 
        return m_impl->totalPackets(); 
    }

    void InertialNode::timeout(uint64 timeout)                                        
    { 
        m_impl->timeout(timeout); 
    }

    uint64 InertialNode::timeout()
    {
        return m_impl->timeout();
    }

    std::string InertialNode::name()
    {
        return deviceName(info().serialNumber());
    }

    bool InertialNode::ping()                                                        
    { 
        return m_impl->ping(); 
    }

    void InertialNode::setToIdle()
    {
        m_impl->setToIdle();
    }

    void InertialNode::resume()
    {
        m_impl->resume();
    }

    uint16 InertialNode::getDataRateBase(InertialTypes::InertialCategory category)
    { 
        return m_impl->getDataRateBase(category);
    }

    InertialChannels InertialNode::getActiveChannelFields(InertialTypes::InertialCategory category)
    { 
        return m_impl->getMessageFormat(category);
    }

    void InertialNode::setActiveChannelFields(InertialTypes::InertialCategory category, const InertialChannels& channels)
    { 
        m_impl->setMessageFormat(category, channels);
    }

    uint8 InertialNode::getCommunicationMode()                                                    
    { 
        return m_impl->getCommunicationMode(); 
    }

    void InertialNode::setCommunicationMode(uint8 communicationMode)                            
    { 
        m_impl->setCommunicationMode(communicationMode); 
    }

    void InertialNode::enableDataStream(InertialTypes::InertialCategory category, bool enable)
    {
        m_impl->enableDataStream(category, enable);
    }

    void InertialNode::resetFilter()
    {
        m_impl->resetFilter();
    }

    bool InertialNode::getAutoInitialization()
    {
        return m_impl->getAutoInitialization();
    }

    void InertialNode::setAutoInitialization(bool enable)
    {
        m_impl->setAutoInitialization(enable);
    }

    void InertialNode::setInitialAttitude(const EulerAngles& attitude)
    {
        m_impl->setInitialAttitude(attitude);
    }

    void InertialNode::setInitialHeading(float heading)
    {
        m_impl->setInitialHeading(heading);
    }

    EulerAngles InertialNode::getSensorToVehicleTransformation()
    {
        return m_impl->getSensorToVehicleTransformation();
    }

    void InertialNode::setSensorToVehicleTransformation(const EulerAngles& angles)
    {
        m_impl->setSensorToVehicleTransformation(angles);
    }

    PositionOffset InertialNode::getSensorToVehicleOffset()
    {
        return m_impl->getSensorToVehicleOffset();
    }

    void InertialNode::setSensorToVehicleOffset(const PositionOffset& offset)
    {
        m_impl->setSensorToVehicleOffset(offset);
    }

    PositionOffset InertialNode::getAntennaOffset()
    {
        return m_impl->getAntennaOffset();
    }

    void InertialNode::setAntennaOffset(const PositionOffset& offset)
    {
        m_impl->setAntennaOffset(offset);
    }
}
