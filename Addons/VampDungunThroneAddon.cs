
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class VampDungunThroneAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new VampDungunThroneAddonDeed();
			}
		}

		[ Constructable ]
		public VampDungunThroneAddon()
		{



			AddComplexComponent( (BaseAddon) this, 1837, 2, -2, 0, 1429, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 3264, 0, 2, 18, 2273, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 4633, 1, -1, 5, 2273, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 4633, 1, 0, 5, 2273, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 3264, 0, 0, 17, 2273, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1825, 0, -1, 0, 1429, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1825, 1, -1, 0, 1437, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 1843, 2, 0, 0, 1429, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 3267, -1, -2, 1, 2273, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1830, -1, 1, 0, 1429, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 1826, 0, 1, 0, 1429, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1825, 1, 0, 0, 1429, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 9037, -2, -2, 0, 2273, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 3267, -1, -2, 0, 2273, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 9035, 0, -2, 2, 2273, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 1826, 1, 1, 0, 1429, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 1828, 0, -2, 0, 1429, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 1828, 1, -2, 0, 1429, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 9037, -2, 0, 0, 2273, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 1835, 2, 1, 0, 1429, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 1840, 2, -1, 0, 1429, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 9037, -2, -1, 0, 2273, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 9037, -2, 1, 0, 2273, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 1825, 0, 0, 0, 1429, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 1830, -1, -2, 0, 1429, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 3264, -1, 0, 8, 2273, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 1830, -1, -1, 0, 1429, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 9035, 0, 1, 2, 2273, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 3267, -1, 1, 0, 2273, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 1830, -1, 0, 0, 1429, -1, "", 1);// 30

		}

		public VampDungunThroneAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class VampDungunThroneAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new VampDungunThroneAddon();
			}
		}

		[Constructable]
		public VampDungunThroneAddonDeed()
		{
			Name = "VampDungunThrone";
		}

		public VampDungunThroneAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}