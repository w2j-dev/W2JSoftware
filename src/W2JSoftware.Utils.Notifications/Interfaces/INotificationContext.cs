using System;
using System.Collections.Generic;
using W2JSoftware.Utils.Common.Models.Errors;

namespace W2JSoftware.Utils.Notifications.Interfaces
{
    public interface INotificationContext
    {
        IList<Error> Notifications { get; }
        bool HasNotifications { get; }

        IList<Error> Errors { get; }

        public IList<Error> Warnings { get; }

        IList<Error> Informations { get; }

        bool HasErrors { get; }

        bool HasWarnings {get;}

        bool HasInformations { get; }

        void Add(Error error);
        void AddRange(IEnumerable<Error> errors);
        void ClearNotifications();
        void ClearNotifications(Type type);
    }
}
