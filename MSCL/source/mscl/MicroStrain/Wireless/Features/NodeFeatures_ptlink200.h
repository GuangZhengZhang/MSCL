/*******************************************************************************
Copyright(c) 2015-2021 Parker Hannifin Corp. All rights reserved.

MIT Licensed. See the included LICENSE.txt for a copy of the full MIT License.
*******************************************************************************/
#pragma once

#include "NodeFeatures_200series.h"

namespace mscl
{
    //Class: NodeFeatures_ptlink200
    //    Contains information on features for the PT-Link-200 nodes. Inherits from <NodeFeatures>.
    class NodeFeatures_ptlink200: public NodeFeatures_200series
    {
    private:
        NodeFeatures_ptlink200();    //disabled default constructor

    public:
        virtual ~NodeFeatures_ptlink200(){};

        //Constructor: NodeFeatures_ptlink200
        //    Creates a NodeFeatures_ptlink200 object.
        NodeFeatures_ptlink200(const NodeInfo& info);

        virtual bool supportsSensorDelayConfig() const override;

        virtual const WirelessTypes::DerivedChannelMasks channelsPerDerivedCategory() const override;

        virtual const WirelessTypes::Filters lowPassFilters() const override;

        virtual WirelessTypes::WirelessSampleRate maxSampleRateForLowPassFilter(WirelessTypes::Filter lowPassFilter, WirelessTypes::SamplingMode samplingMode, WirelessTypes::DataCollectionMethod dataCollectionMethod, WirelessTypes::DataMode dataMode, const ChannelMask& channels) const override;
        
        virtual const WirelessTypes::VoltageType adcVoltageInputType() const override;

        virtual bool supportsPoll() const override;

        virtual const WirelessTypes::WirelessSampleRates sampleRates(WirelessTypes::SamplingMode samplingMode, WirelessTypes::DataCollectionMethod dataCollectionMethod, WirelessTypes::DataMode dataMode) const override;

        const uint32 minSensorDelay() const override;

        const uint32 defaultSensorDelay() const override;
    };
}

