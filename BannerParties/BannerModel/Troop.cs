using System;

namespace BannerModel
{
    public class Troop
    {
        int Healthpoints;
        bool Healthy { get { return (Healthpoints > 49); } }

    }
}
