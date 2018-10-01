﻿namespace NetEscapades.AspNetCore.SecurityHeaders.Infrastructure
{
    /// <summary>
    /// Controls whether the current document is allowed to use the
    /// <code>Geolocation</code> Interface. When this policy is enabled,
    /// calls to <code>getCurrentPosition()</code> and <code>watchPosition()</code>
    /// will cause those functions' callbacks to be invoked with a 
    /// <code>PositionError</code> code of <code>PERMISSION_DENIED</code>.
    /// </summary>
    public class GeolocationFeaturePolicyDirectiveBuilder : FeaturePolicyDirectiveBuilder
    {
        public GeolocationFeaturePolicyDirectiveBuilder() : base("geolocation")
        {
        }
    }
}