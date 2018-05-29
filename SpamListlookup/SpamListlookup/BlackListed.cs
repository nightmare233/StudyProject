using System;
using System.Collections.Generic;
using System.Text;

namespace SpamListlookup
{
   public class BlackListed
    {
        #region private fields

        private bool _IsListed;
        private string _verifiedonserver;

        #endregion

        #region Class properties

        public string VerifiedOnServer
        {
            get { return _verifiedonserver; }
        }

        public bool IsListed
        {
            get { return _IsListed; }
        }

        #endregion

        #region Contructor

        public BlackListed(bool listed, string server)
        {
            this._IsListed = listed;
            this._verifiedonserver = server;
        }

        #endregion
    }
}
