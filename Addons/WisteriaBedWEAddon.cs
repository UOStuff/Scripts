
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
	public class WisteriaBedWEAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new WisteriaBedWEAddonDeed();
			}
		}

		[ Constructable ]
		public WisteriaBedWEAddon()
		{



			AddComplexComponent( (BaseAddon) this, 3123, 1, 2, 0, 2479, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 3124, -1, 2, 0, 2479, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 3125, 1, 1, 0, 2479, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 3123, 0, 2, 0, 2479, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 3125, 0, 0, 0, 2479, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 3125, 1, 0, 0, 2479, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 3125, -1, 0, 0, 2479, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 3125, 0, 1, 0, 2479, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 3125, -1, 1, 0, 2479, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 5028, -1, 2, 4, 2479, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 5028, -1, 1, 4, 2479, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 5028, -1, 0, 4, 2479, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 10010, 1, 2, 3, 2479, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 10010, 1, 1, 3, 2479, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 10010, 1, 0, 3, 2479, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 10075, 1, 2, 0, 2479, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 10075, 1, 2, 9, 2479, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 10075, 1, -1, 0, 2479, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 10075, 1, -1, 9, 2479, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 10383, -2, 2, 1, 2479, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 10383, -2, 1, 1, 2479, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 10383, -2, 0, 1, 2479, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 10075, -2, 2, 0, 2479, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 10075, -2, 2, 9, 2479, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 10075, -2, -1, 0, 2479, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 10075, -2, -1, 9, 2479, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 3244, -1, 0, 18, 2212, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 3244, -1, 1, 18, 2212, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 3244, -1, 2, 18, 2212, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 3205, -2, -1, 13, 2479, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 3205, 1, -1, 14, 2479, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 3205, 1, 2, 14, 2479, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 3205, -2, 2, 15, 2479, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 3244, 2, 1, 17, 2212, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 3244, 2, 2, 17, 2212, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 3244, 2, 0, 17, 2212, -1, "", 1);// 36

		}

		public WisteriaBedWEAddon( Serial serial ) : base( serial )
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

	public class WisteriaBedWEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new WisteriaBedWEAddon();
			}
		}

		[Constructable]
		public WisteriaBedWEAddonDeed()
		{
			Name = "WisteriaBedWE";
		}

		public WisteriaBedWEAddonDeed( Serial serial ) : base( serial )
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