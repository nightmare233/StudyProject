using System;
using System.Net;
using System.Collections.Generic;
using System.Text;

namespace SpamListlookup
{
    public class VerifyIP
    {
        #region Private fields

        private exIPAddress _ip;
        private BlackListed _blacklisted = new BlackListed(false, "");
        private string _returncode;
        private string _times;

        #endregion

        #region Class Properties

        public exIPAddress IPAddr
        {
            get { return _ip; }
            set { _ip = value; }
        }

        public BlackListed BlackList
        {
            get { return _blacklisted; }
        }

        public string Times
        {
            get { return _times; }
            set { _times = value; }
        }

        public string Returncode
        {
            get { return _returncode; }
            set { _returncode = value; }
        }



        #endregion

        #region Constructors

        public VerifyIP(byte[] address, string[] blacklistservers)
        {
            _ip = new exIPAddress(address);
            VerifyOnServers(blacklistservers);
        }
        public VerifyIP(long address, string[] blacklistservers)
        {
            _ip = new exIPAddress(address);
            VerifyOnServers(blacklistservers);
        }
        public VerifyIP(string address, string[] blacklistservers)
        {
            _ip = new exIPAddress(address);
            VerifyOnServers(blacklistservers);
        }
        public VerifyIP(exIPAddress address, string[] blacklistservers)
        {
            _ip = address;
            VerifyOnServers(blacklistservers);
        }

        #endregion

        #region Private methods

        private void VerifyOnServers(string[] _blacklistservers)
        {

            _blacklisted = null;
            if (_blacklistservers != null && _blacklistservers.Length > 0)
            {
                foreach (string BLSrv in _blacklistservers)
                {
                    if (VerifyOnServer(BLSrv))
                    {
                        _blacklisted = new BlackListed(true, BLSrv);
                        break;
                    }
                }
                if (_blacklisted == null)
                    _blacklisted = new BlackListed(false, "");
            }
        }
        /// <summary>
        /// key method.
        /// </summary>
        /// <param name="BLServer"></param>
        /// <returns></returns>
        private bool VerifyOnServer(string BLServer)
        {
            //if (_ip.Valid)  //If ip address is valid continue..
            //{
            try
            {
                string address = _ip.AsRevString + "." + BLServer;
                //string address = "22fgfdgf3.com" + "." + BLServer;

                System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

                stopwatch.Start();

                //string address = "83.25.108.202.zen.spamhaus.org";

                IPHostEntry ipEntry = Dns.GetHostEntry(address);  //Look up the ip address on the BLServer

                stopwatch.Stop();

                _times = String.Format("×ÜºÄÊ±{0}Ãë", stopwatch.Elapsed.TotalSeconds);


                _returncode = ipEntry.AddressList[0].ToString();

                ipEntry = null; //Clear the object 

                return ReturnCodes.isInReturnCodes(_returncode);

                //return true; //Ip address was found on the BLServer, its then listed in the black list
            }
            catch (System.Net.Sockets.SocketException dnserr)
            {
                //if (dnserr.ErrorCode == 11001) // Ip address not listed
                //    return false;
                //else // Another error happend, put other error handling here
                //    return false;
                throw dnserr;
            }
            //}
            //else
            //    throw new Exception("Invalid IP Address");   //Ip address is not valid
        }

        private string BuildCode(string code)
        {
            return null;
        }

        #endregion
    }
}
