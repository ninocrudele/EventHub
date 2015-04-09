﻿#region Copyright 
//======================================================================================= 
// Copyright (c) Nino Crudele.http://ninocrudele.me/ All rights reserved. 
//  
// LICENSED UNDER THE APACHE LICENSE, VERSION 2.0 (THE "LICENSE"); YOU MAY NOT USE THESE  
// FILES EXCEPT IN COMPLIANCE WITH THE LICENSE. YOU MAY OBTAIN A COPY OF THE LICENSE AT  
// http://www.apache.org/licenses/LICENSE-2.0 
// UNLESS REQUIRED BY APPLICABLE LAW OR AGREED TO IN WRITING, SOFTWARE DISTRIBUTED UNDER THE  
// LICENSE IS DISTRIBUTED ON AN "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY  
// KIND, EITHER EXPRESS OR IMPLIED. SEE THE LICENSE FOR THE SPECIFIC LANGUAGE GOVERNING  
// PERMISSIONS AND LIMITATIONS UNDER THE LICENSE. 
//======================================================================================= 
#endregion 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Receiver
{
    [DataContract]
    public class SampleMessage
    {
        [DataMember]
        public string TransactionID { get; set; }
        [DataMember]
        public int MessageNumber { get; set; }
        [DataMember]
        public string SenderId { get; set; }
    }


}
