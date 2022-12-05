using System;

namespace IS_2_20_BolotovaAA_U
{
    public class Accessories
    {
        public Accessories()
        {

        }
        public int price;
        public int YearRelease;
    }
    public class HardDrives : Accessories
    {
        public int NumberTurnovers;
        public string Interface;
        public int Volume;
    }
    public class VideoCard : Accessories
    {
        public int FrequencyGPU;
        public string Manufacturer;
        public int MemoryCapacity;
    }


}
