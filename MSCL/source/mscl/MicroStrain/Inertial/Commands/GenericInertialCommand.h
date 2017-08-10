/*******************************************************************************
Copyright(c) 2015-2017 LORD Corporation. All rights reserved.

MIT Licensed. See the included LICENSE.txt for a copy of the full MIT License.
*******************************************************************************/
#pragma once

#include "mscl/MicroStrain/ResponsePattern.h"
#include "mscl/MicroStrain/Inertial/InertialTypes.h"
#include "InertialCmdResponse.h"

namespace mscl
{
    //Title: GenericInertialCommand

    //Class: GenericInertialCommandResponse
    //    Represents the response to a GenericInertialCommand.
    //
    //See Also:
    //    <InertialCmdResponse>
    class GenericInertialCommandResponse : public InertialCmdResponse
    {
    public:
        //Constructor: GenericInertialCommandResponse
        //    Creates a GenericInertialCommandResponse with default values.
        GenericInertialCommandResponse();

    private:
        //Constructor: GenericInertialCommandResponse
        //    Creates a GenericInertialCommandResponse with the given parameters.
        //
        //Parameters:
        //    state - The state of the response.
        //    success - Whether or not the command was a success.
        //    errorCode - The MIP Ack/Nack error code received.
        //    cmdName - The name of the command.
        //    data - The <ByteStream> that holds the result data from the response (if any).
        GenericInertialCommandResponse(ResponsePattern::State state, bool success, InertialPacket::MipAckNack errorCode, std::string cmdName, ByteStream data);

#ifndef SWIG
    public:
        //Function: ResponseSuccess
        //    Creates a GenericInertialCommandResponse with a successful response.
        //
        //Parameters:
        //    cmdName - The name of the command.
        //    data - The <ByteStream that holds the data from the response (if any).
        //
        //Returns:
        //    A <GenericInertialCommandResponse> representing a success response from the command.
        static GenericInertialCommandResponse ResponseSuccess(const std::string& cmdName, ByteStream data = ByteStream());

        //Function: ResponseFail
        //    Creates a GenericInertialCommandResponse with a fail response.
        //
        //Parameters:
        //    errorState - The state that caused the ResponseFail.
        //    errorCode - The MIP Ack/Nack error code to set with the ResponseFail.
        //    cmdName - The name of the command.
        //
        //Returns:
        //    A <GenericInertialCommandResponse> representing a failed response from the command.
        static GenericInertialCommandResponse ResponseFail(ResponsePattern::State errorState, InertialPacket::MipAckNack errorCode, const std::string& cmdName);
#endif

    private:
        //Variable: m_data
        //    The <ByteStream that holds the data received from the response, if any.
        ByteStream m_data;

    public:
        //Function: data
        //    Gets the data that was received from the response, if any.
        //
        //Returns:
        //    A <ByteStream> that contains the data received from the response, if any.
        ByteStream data() const;
    };



    //Class: GenericInertialCommand
    //    Represents a base class for Inertial commands
    class GenericInertialCommand
    {
    protected:
        static const uint8 FIELD_ACK_NACK_BYTE = 0xF1;

    protected:
        GenericInertialCommand(InertialTypes::Command commandId);           // constructor taking the command ID
        GenericInertialCommand() {}                                            //disabled default constructor

    private:
        GenericInertialCommand(const GenericInertialCommand&);                //disabled copy constructor
        GenericInertialCommand& operator=(const GenericInertialCommand&);    //disabled assignment operator

    public:
        virtual ~GenericInertialCommand(){};

    public:
        //Function: buildCommand
        //    Builds the command for an Inertial command, and returns a ByteStream containing the bytes to send
        //
        //Parameters:
        //    descSetByte - The descriptor set byte for the command
        //    cmdByte - The command (field) byte for the command
        //    fieldData - A vector of bytes that make up the field data to be sent in the command (defaults to empty)
        //
        //Returns:
        //    A <ByteStream> containing the Inertial command packet built from the given bytes
        static ByteStream buildCommand(uint8 descSetByte, uint8 cmdByte, const Bytes& fieldData = Bytes());

        //Function: buildCommand
        //    Builds the command for an Inertial command, and returns a ByteStream containing the bytes to send
        //
        //Parameters:
        //    commandId - The <InertialTypes::Command> for the command
        //    fieldData - A vector of bytes that make up the field data to be sent in the command (defaults to empty)
        //
        //Returns:
        //    A <ByteStream> containing the Inertial command packet built from the given bytes
        static ByteStream buildCommand(InertialTypes::Command commandId, const Bytes& fieldData = Bytes());

        //Function: buildCommand
        //    Builds the command for a derived Inertial command, and returns a ByteStream containing the bytes to send
        //
        //Parameters:
        //    fieldData - A vector of bytes that make up the field data to be sent in the command (defaults to empty)
        //
        //Returns:
        //    A <ByteStream> containing the Inertial command packet built from the given bytes
        ByteStream buildCommand(const Bytes& fieldData = Bytes());

        //Function: fieldId
        //    Gets the <InertialTypes::Command>
        virtual InertialTypes::Command commandId() const = 0;

        //Class: Response
        //    Handles the response to the Inertial command
        class Response : public ResponsePattern
        {
            friend class InertialNode_Impl;

        protected:
            //Variable: m_ackNackResponse
            //    Whether or not an ack/nack response field is expected
            bool m_ackNackResponse;

            //Variable: m_dataResponse
            //    Whether or not a data response field is expected
            bool m_dataResponse;

            //Variable: m_command
            //    The command enumeration
            const InertialTypes::Command m_command;

            //Variable: m_commandName
            //    The name of the command
            std::string m_commandName;

            //Variable: m_fieldDataByte
            //    The field data byte.
            uint8 m_fieldDataByte;

            //Variable: m_result
            //    The <GenericInertialCommandResponse> that holds the result of the GenericInertialCommand
            GenericInertialCommandResponse m_result;

        protected:
            //Function: commandId
            //    Gets the <InertialTypes::Command> for the Inertial command
            virtual InertialTypes::Command commandId() const { return m_command; }

            //Function: fieldDataByte
            //    Gets the data field byte that should be received with the data field (if any)
            virtual uint8 fieldDataByte() const;

            //Function: descSetByte
            //    Gets the descriptor set byte for the Inertial command
            uint8 descSetByte() const;

            //Function: cmdByte
            //    Gets the command byte for the Inertial command
            uint8 cmdByte() const;

            //Function: fieldAckNackByte
            //    Gets the ack/nack byte that should be received with the ack/nack field
            uint8 fieldAckNackByte() const;

        public:
            //Default Constructor: Response
            //    Creates a default constructor Response.
            //    Note: You will need to use the <setResponseCollector> function before being used.
            //
            //Parameters:
            //    ackNackResponse - Whether or not an ack/nack response field is expected
            //    dataResponse - Whether or not a data response field is expected
            //    cmdName - The name of the command (to be used in exceptions that may be thrown)
            Response(const InertialTypes::Command&, bool ackNackResponse, bool dataResponse, std::string cmdName);

            //Constructor: Response
            //    Creates a Response object
            //
            //Parameters:
            //    collector - The <ResponseCollector> used to register and unregister the response
            //    ackNackResponse - Whether or not an ack/nack response field is expected
            //    dataResponse - Whether or not a data response field is expected
            //    cmdName - The name of the command (to be used in exceptions that may be thrown)
            Response(const InertialTypes::Command&, std::weak_ptr<ResponseCollector> collector, bool ackNackResponse,
                     bool dataResponse, const std::string& cmdName, uint8 fieldDataByte = 0);

            virtual ~Response(){};

        public:
            //Function: match
            //    Checks if the <InertialDataField> passed in matches the expected response pattern's bytes
            //
            //Parameters:
            //    field - The <InertialDataField> in which to try to find the pattern
            //
            //Returns:
            //    true if the packet matches a response pattern, false otherwise
            virtual bool match(const InertialDataField& field) override;

            //Function: match_ackNack
            //    Checks if the <InertialDataField> matches the ACK/NACK field for this command (if one is even expected)
            //
            //Parameters:
            //    field - The <InertialDataField> in which to try to find the pattern
            //
            //Returns:
            //    true if the packet matches the expected response pattern, false otherwise
            bool match_ackNack(const InertialDataField& field);

            //Function: match_data
            //    Checks if the <InertialDataField> matches the data field for this command (if one is even expected)
            //
            //Parameters:
            //    field - The <InertialDataField> in which to try to find the pattern
            //
            //Returns:
            //    true if the packet matches the expected response pattern, false otherwise
            virtual bool match_data(const InertialDataField& field);

            //Function: wait
            //    Waits for a certain amount of time for the response pattern to be matched
            //
            //Parameters:
            //    timeout - The maximum time (in milliseconds) to wait until the command times out and returns, if not found first
            //
            //Returns:
            //    true if the response pattern was matched, false otherwise
            bool wait(uint64 timeout);

            //Function: result
            //    Gets the <GenericInertialCommandResponse> that holds the result of the response
            //
            //Returns:
            //    A <GenericInertialCommandResponse> that holds the result of the response
            GenericInertialCommandResponse result();
        };
    };
}