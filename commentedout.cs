    /*StartRecordingOptions recordingOptions = new StartRecordingOptions(new ServerCallLocator(callerId)) 
            {
                RecordingContent = RecordingContent.Audio,
                RecordingChannel = RecordingChannel.Unmixed,
                RecordingFormat = RecordingFormat.Wav,
                RecordingStateCallbackUri = callbackUri
            };
            Response<RecordingStateResult> response = await client.GetCallRecording().StartAsync(recordingOptions);*/
        }
        /*client.GetEventProcessor().AttachOngoingEventProcessor<PlayCompleted>(answerCallResult.CallConnection.CallConnectionId, async (playCompletedEvent) =>
        {
            logger.LogInformation($"Play completed event received for connection id: {playCompletedEvent.CallConnectionId}.");
            //Ending of Call
            //if (!string.IsNullOrWhiteSpace(playCompletedEvent.OperationContext) && (playCompletedEvent.OperationContext.Equals(transferFailedContext, StringComparison.OrdinalIgnoreCase) 
            //|| playCompletedEvent.OperationContext.Equals(goodbyeContext, StringComparison.OrdinalIgnoreCase)))
            //{
            //logger.LogInformation($"Disconnecting the call...");
            //await answerCallResult.CallConnection.HangUpAsync(true);
                
            //}
            //eddited, used to not always be false and had else if
            if (false &&!string.IsNullOrWhiteSpace(playCompletedEvent.OperationContext) && playCompletedEvent.OperationContext.Equals(connectAgentContext, StringComparison.OrdinalIgnoreCase))
            {
                if (string.IsNullOrWhiteSpace(forwardtonumber))
                {
                    logger.LogInformation($"Agent phone number is empty");
                    await HandlePlayAsync(forwardtonumberEmptyPrompt,
                      transferFailedContext, answerCallResult.CallConnection.GetCallMedia(), logger);
                }
                else
                {
                    logger.LogInformation($"Initializing the Call transfer...");
                    CommunicationIdentifier transferDestination = new PhoneNumberIdentifier(forwardtonumber);
                    TransferCallToParticipantResult result = await answerCallResult.CallConnection.TransferCallToParticipantAsync(transferDestination);
                    logger.LogInformation($"Transfer call initiated: {result.OperationContext}");
                }
            }
        });*/



        /*int calledorderindex=1;
        if (open && numberorderopen[0]!="") {
            logger.LogInformation($"Initializing the Call transfer...");
            CommunicationIdentifier transferDestination = new PhoneNumberIdentifier(order[0]);
            TransferCallToParticipantResult result = await answerCallResult.CallConnection.TransferCallToParticipantAsync(transferDestination);
            logger.LogInformation($"Transfer call initiated: {result.OperationContext}");
            
            
        } else if (!open && numberorderclosed[0]!="") {
            logger.LogInformation($"Initializing the Call transfer...");
            CommunicationIdentifier transferDestination = new PhoneNumberIdentifier(order[0]);
            TransferCallToParticipantResult result = await answerCallResult.CallConnection.TransferCallToParticipantAsync(transferDestination);
            logger.LogInformation($"Transfer call initiated: {result.OperationContext}");
            
        }*/