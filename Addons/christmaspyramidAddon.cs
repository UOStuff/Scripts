
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
	public class christmaspyramidAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new christmaspyramidAddonDeed();
			}
		}

		[ Constructable ]
		public christmaspyramidAddon()
		{



			AddComplexComponent( (BaseAddon) this, 9001, 2, -1, 0, 2940, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 9001, 1, 0, 0, 2940, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 9000, 0, 1, 0, 2940, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 9000, -1, 2, 0, 2940, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 9000, 0, 2, 16, 2270, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 9000, 1, 1, 16, 2270, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 9001, 2, 0, 16, 2270, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 9001, 2, 1, 33, 2437, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 9000, 1, 2, 33, 2437, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 9000, 2, 2, 49, 2749, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 9009, 0, 2, 2, 1260, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 9009, 1, 1, 2, 2747, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 9009, 2, 0, 2, 1260, -1, "", 1);// 13

		}

		public christmaspyramidAddon( Serial serial ) : base( serial )
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

	public class christmaspyramidAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new christmaspyramidAddon();
			}
		}

		[Constructable]
		public christmaspyramidAddonDeed()
		{
			Name = "christmaspyramid";
		}

		public christmaspyramidAddonDeed( Serial serial ) : base( serial )
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