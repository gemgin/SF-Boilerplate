﻿using SF.Core.Abstraction.Entitys;

namespace SF.Core.Entitys
{
    public class DistrictEntity : BaseEntity
    {
        public long StateOrProvinceId { get; set; }

        public virtual StateOrProvinceEntity StateOrProvince { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Location { get; set; }
    }
}
