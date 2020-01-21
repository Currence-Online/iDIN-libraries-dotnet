namespace BankId.Merchant.Library.MessageBuilders
{
    internal interface IIDxMessageBuilder
    {
        string GetDirectoryRequest();
        string GetTransactionRequest(AuthenticationRequest authenticationRequest, string containedData);
        string GetStatusRequest(StatusRequest statusRequest);
    }
}