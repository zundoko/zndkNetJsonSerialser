using System.Collections.Generic;
using System.Runtime.Serialization;

namespace zndkNetJsonSerialser
{
    [DataContract]
    class clszndkconf
    {
        // file header
        [DataMember(Order = 0)]
        public string           name      { get; set; }
        [DataMember(Order = 1)]
        public string           brief     { get; set; }
        [DataMember(Order = 2)]
        public string           note      { get; set; }
        [DataMember(Order = 3)]
        public string           date      { get; set; }
        [DataMember(Order = 4)]
        public string           author    { get; set; }

        // zndk configuration
        [DataMember(Order = 5)]
        public zndkConf         conf      { get; set; }

        [DataMember(Order = 6)]
        public int              cnt       { get; set; }
    }

    [DataContract]
    class zndkConf
    {
        [DataMember(Order = 0, Name = "id")]
        public int              ID        { get; set; }
        [DataMember(Order = 1)]
        public double           coeff     { get; set; }
        [DataMember(Order = 2)]
        public int              nsvr      { get; set; } // # of servers
        [DataMember(Order = 3)]
        public List<zndkSvr>    tcp       { get; set; }
    }

    [DataContract]
    class zndkSvr
    {
        [DataMember(Order = 0)]
        public string           addr      { get; set; }
        [DataMember(Order = 1)]
        public int              port      { get; set; }
    }
}
