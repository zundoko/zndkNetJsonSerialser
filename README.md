# zndkNetJsonSerialser
JSON formatted file R/W test w/ .NET DataContractJsonSerializer (VS2015 community)

zndkConf.json:
```json
{
    "//": "file header",
    "name"  : "zndkConf.json",
    "brief" : "test for DataContractJsonSerializer (.NET)",
    "note"  : "test on .NET Framework 4.6.1",
    "date"  : "2017-01-15",
    "author": "zundoko",

    "//": "zndk configuration",
    "conf"  : {
        "ID"   : "0x01234567",
        "coeff": 0.001,
        "nsvr" : 3,
        "tcp" : [
            {
                "addr": "192.168.0.1",
                "port": 50001
            },
            {
                "addr": "192.168.0.2",
                "port": 50002
            },
            {
                "addr": "192.168.0.3",
                "port": 50003
            }
        ]
    },

    "//": "counter for updateing this file.",
    "cnt"   : 0
}
```

<pre>
==============================: file header
@file   zndkConf.json
@brief  test for DataContractJsonSerializer (.NET)
@note   test on .NET Framework 4.6.1
@date   2017-01-15
@author zundoko
==============================: zndk configuration
ID      0
coeff   0.001
nsvr    3
==============================: zndk configuration > svr
------------------------------: zndk configuration > svr 0
tcp server 0: addr=192.168.0.1
tcp server 0: port=50001
------------------------------: zndk configuration > svr 1
tcp server 1: addr=192.168.0.2
tcp server 1: port=50002
------------------------------: zndk configuration > svr 2
tcp server 2: addr=192.168.0.3
tcp server 2: port=50003
==============================: test conter
cnt     0
done
Press ANY key to continue...
</pre>
