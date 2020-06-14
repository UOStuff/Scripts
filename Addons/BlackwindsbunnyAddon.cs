
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
	public class BlackwindsbunnyAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BlackwindsbunnyAddonDeed();
			}
		}

		[ Constructable ]
		public BlackwindsbunnyAddon()
		{



			AddComplexComponent( (BaseAddon) this, 5915, 0, 0, 15, 2747, -1, "Blackwind Bunny", 1);// 1
			AddComplexComponent( (BaseAddon) this, 5908, 1, 0, 17, 2747, -1, "Blackwind Bunny", 1);// 2
			AddComplexComponent( (BaseAddon) this, 3576, 0, 0, 5, 2747, -1, "Blackwind Bunny", 1);// 3
			AddComplexComponent( (BaseAddon) this, 10145, 0, 0, 4, 2747, -1, "Blackwind Bunny", 1);// 4
			AddComplexComponent( (BaseAddon) this, 3576, 0, 0, 9, 2747, -1, "Blackwind Bunny", 1);// 5
			AddComplexComponent( (BaseAddon) this, 5444, 0, 0, 12, 2747, -1, "Blackwind Bunny", 1);// 6
			AddComplexComponent( (BaseAddon) this, 14079, 0, 0, 3, 2747, -1, "Blackwind Bunny", 1);// 7
			AddComplexComponent( (BaseAddon) this, 3981, 1, 0, 9, 2747, -1, "Blackwind Bunny Tail", 1);// 8
			AddComplexComponent( (BaseAddon) this, 3614, 0, 0, 6, 2747, -1, "Blackwind Bunny", 1);// 9
			AddComplexComponent( (BaseAddon) this, 10134, 0, 0, 0, 2747, -1, "Blackwind Bunny", 1);// 10
			AddComplexComponent( (BaseAddon) this, 3962, 0, 0, 11, 2747, -1, "Blackwind Bunny", 1);// 11

		}

		public BlackwindsbunnyAddon( Serial serial ) : base( serial )
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

	public class BlackwindsbunnyAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BlackwindsbunnyAddon();
			}
		}

		[Constructable]
		public BlackwindsbunnyAddonDeed()
		{
			Name = "Blackwindsbunny";
		}

		public BlackwindsbunnyAddonDeed( Serial serial ) : base( serial )
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