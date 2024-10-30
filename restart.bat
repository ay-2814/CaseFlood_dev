@echo off
:Start
dotnet build --configuration Release 
dotnet publish .\CallAutomationOpenAI\CallAutomationOpenAI.csproj -c Release -o .\myapp
:: Wait 30 seconds before restarting.
TIMEOUT /T 30
GOTO:Start