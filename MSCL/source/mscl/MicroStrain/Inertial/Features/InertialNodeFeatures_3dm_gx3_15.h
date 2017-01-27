/*******************************************************************************
Copyright(c) 2015-2017 LORD Corporation. All rights reserved.

MIT Licensed. See the included LICENSE.txt for a copy of the full MIT License.
*******************************************************************************/
#pragma once

#include "InertialNodeFeatures.h"

namespace mscl
{
    //Class: InertialNodeFeatures_3dm_gx3_15
    //    Contains information on features for the 3DM-GX3-15 Node. Inherits from <InertialNodeFeatures>.
    class InertialNodeFeatures_3dm_gx3_15: public InertialNodeFeatures
    {
    public:
        virtual ~InertialNodeFeatures_3dm_gx3_15() {};

        //Constructor: InertialNodeFeatures_3dm_gx3_15
        //    Creates a InertialNodeFeatures_3dm_gx3_15 object.
        InertialNodeFeatures_3dm_gx3_15(const InertialNodeInfo& info);
    };
}