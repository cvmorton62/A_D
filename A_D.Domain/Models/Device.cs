using System;
using System.Collections.Generic;

namespace A_D.Domain.Models
{
    public class Device
    {
        public int Id { get; set; }
        public int DeviceModel_Id { get; set; }
        public int DeviceNfieldVersion_Id { get; set; }
        public int DeviceOS_Id { get; set; }
        public bool Inactive { get; set; }
        public string SerialNumber { get; set; }
        public string VRID { get; set; }
        public DateTime DateCreate { get; set; }
        public string SourceCreate { get; set; }
        public DateTime? DateModify { get; set; }
        public string SourceModify { get; set; }
        public DeviceModel DeviceModel { get; set; }
        public DeviceNfieldVersion DeviceNfieldVersion { get; set; }
        public DeviceOS DeviceOS { get; set; }
        public List<DeviceDeployment> DeviceDeployments { get; set; }
        public List<DeviceNote> DeviceNotes { get; set; }
    }
}
