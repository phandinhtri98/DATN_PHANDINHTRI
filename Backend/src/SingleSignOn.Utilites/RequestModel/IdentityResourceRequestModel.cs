﻿using System.Collections.Generic;

namespace SingleSignOn.Utilites.RequestModel
{
    public class IdentityResourceRequestModel
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public bool ShowInDiscoveryDocument { get; set; }
        public bool Required { get; set; }
        public bool Emphasize { get; set; }
        public List<string> UserClaims { get; set; }
    }
}
