
namespace APIServer.Domain.Core.Models.WebHooks {

    public enum HookEventType {
        
        // Take this as example you can implement any custom event source
        resource,

        file,

        note,

        project,

        milestone

        //etc etc..
    }
}

