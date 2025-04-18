using System;

namespace EventEase.Services
{
    public class UserSessionService
    {
        public string UserName { get; private set; }
        public DateTime SessionStart { get; private set; }

        public void StartSession(string userName)
        {
            UserName = userName;
            SessionStart = DateTime.Now;
        }

        public void EndSession()
        {
            UserName = null;
            SessionStart = DateTime.MinValue;
        }

        public bool IsSessionActive()
        {
            return !string.IsNullOrEmpty(UserName);
        }
    }
}
