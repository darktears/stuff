using System;

namespace xwalk
{
  public class XWalkExtensionInstance
  {
    public XWalkExtensionInstance(dynamic native)
    {
      native_ = native;
      Console.WriteLine("Instance Created");
    }

    public void HandleMessage(String message)
    {
      Console.WriteLine("Message Received : " + message);
      native_.PostMessageToJS(message);
    }
    public void HandleSyncMessage(String message)
    {
      Console.WriteLine("Sync Message Received : " + message);
      native_.SendSyncReply(message);
    }

    private dynamic native_;
  }
}
