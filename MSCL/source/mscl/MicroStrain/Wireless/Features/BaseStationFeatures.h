/*******************************************************************************
Copyright(c) 2015-2017 LORD Corporation. All rights reserved.

MIT Licensed. See the included LICENSE.txt for a copy of the full MIT License.
*******************************************************************************/

#pragma once

#include <map>
#include <memory>
#include "mscl/MicroStrain/Wireless/BaseStationInfo.h"

namespace mscl
{    
    //API Class: BaseStationFeatures
    //    Contains information on which features are supported by a <BaseStation>.
    class BaseStationFeatures
    {
        friend class BaseStationEepromHelper;
        friend class BaseStation_Impl;

    public:
        virtual ~BaseStationFeatures() {};

    private:
        BaseStationFeatures();    //disabled default constructor

    protected:
        //Variable: m_baseInfo
        //    The <BaseStationInfo> object containing basic information retrieved from eeprom about the BaseStation.
        BaseStationInfo m_baseInfo;

    public:
#ifndef SWIG
        //Constructor: BaseStationFeatures
        //    Creates a BaseStationFeatures object.
        //
        //Parameters:
        //    info - A <BaseStationInfo> object representing standard information of the <BaseStation>.
        BaseStationFeatures(BaseStationInfo& info);

        //Function: create
        //    Builds and returns a BaseStationFeatures pointer based on the given parameters.
        //
        //Parameters:
        //    info - A <BaseStationInfo> object representing standard information of the <BaseStation>.
        //
        //Returns:
        //    A BaseStationFeatures unique_ptr.
        //
        //Exceptions:
        //    - <Error_NotSupported>: The BaseStation model is not supported by MSCL.
        static std::unique_ptr<BaseStationFeatures> create(BaseStationInfo& info);
#endif

    public:
        //API Function: supportsTransmitPower
        //    Checks if a <WirelessTypes::TransmitPower> is supported by this BaseStation.
        //
        //Parameters:
        //    power - The <WirelessTypes::TransmitPower> to check if supported.
        //
        //Returns:
        //    true if the transmit power is supported, false otherwise.
        bool supportsTransmitPower(WirelessTypes::TransmitPower power) const;

        //API Function: supportsButtons
        //    Checks if the BaseStation supports Button configuration.
        //    
        //Returns:
        //    true if the BaseStation supports Button configuration, false otherwise.
        bool supportsButtons() const;

        //API Function: supportsAnalogPairing
        //    Checks if the BaseStation supports Analog Pairing configuration.
        //
        //Returns:
        //    true if the BaseStation supports Analog Pairing, false otherwise.
        bool supportsAnalogPairing() const;

        //API Function: supportsBeaconStatus
        //    Checks if the BaseStation supports the beaconStatus command.
        //
        //Returns:
        //    true if the BaseStation supports the beacon status command, false otherwise.
        bool supportsBeaconStatus() const;

        //API Function: supportsRfSweepMode
        //  Checks if the BaseStation supports RF Sweep Mode.
        //  Note: This checks if the standard RF sweep mode across the BaseStation's supported operating frequencies is supported.
        //        Use <supportsCustomRfSweepMode> to check if customizing the frequencies to be scanned is supported.
        //
        //Returns:
        //  true if the BaseStation supports RF Sweep Mode, false otherwise.
        bool supportsRfSweepMode() const;

        //API Function: supportsCustomRfSweepMode
        //  Checks if the BaseStation supports the Custom RF Sweep Mode (providing custom frequency ranges).
        //
        //Returns:
        //  true if the BaseStation supports Custom RF Sweep Mode, false otherwise.
        bool supportsCustomRfSweepMode() const;

        //API Function: buttonCount
        //    Gets the total number of buttons that are supported.
        //
        //Returns:
        //    The total number of buttons that are supported.
        virtual uint8 buttonCount() const;

        //API Function: analogPortCount
        //    Gets the total number of analog ports that are supported.
        //
        //Returns:
        //    The total number of analog ports that are supported.
        virtual uint8 analogPortCount() const;

        //API Function: transmitPowers
        //    Gets a list of the <WirelessTypes::TransmitPowers> that are supported by this BaseStation.
        //
        //Returns:
        //    A vector of <WirelessTypes::TransmitPowers> that are supported by this BaseStation.
        virtual const WirelessTypes::TransmitPowers transmitPowers() const;

    protected:
        //Function: supportsNewTransmitPowers
        //    Checks if the BaseStation supports the new transmit powers (true), or the old ones (false).
        virtual bool supportsNewTransmitPowers() const;

        //Function: supportsEepromCommitViaRadioReset
        //    Checks if eeprom changes can be committed by only cycling the radio, instead of cycling power.
        virtual bool supportsEepromCommitViaRadioReset() const;
    };
}