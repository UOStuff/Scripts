
////////////////////////////////////////
//                                     //
//   Generated by CEO's YAAAG - Ver 2  //
// (Yet Another Arya Addon Generator)  //
//    Modified by Hammerhand for       //
//      SA & High Seas content         //
//                                     //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class HedgeFlagEastAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new HedgeFlagEastAddonDeed();
			}
		}

		[ Constructable ]
		public HedgeFlagEastAddon()
		{



			AddComplexComponent( (BaseAddon) this, 3215, -2, -1, 0, 302, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 3215, -2, 0, 0, 302, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 3215, -1, -1, 0, 302, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 3215, -1, 0, 0, 302, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 3215, 0, -1, 0, 132, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 3215, 0, 0, 0, 2461, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 3215, 1, -1, 0, 132, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 3215, 1, 0, 0, 2461, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 3215, 2, -1, 0, 132, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 3215, 2, 0, 0, 2461, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 3215, -2, 1, 0, 132, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 3215, -1, 1, 0, 132, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 3215, 0, 1, 0, 132, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 3215, 1, 1, 0, 132, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 3215, 2, 1, 0, 132, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 10231, -2, -1, 6, 2461, -1, "Star", 1);// 16
			AddComplexComponent( (BaseAddon) this, 10231, -1, -1, 6, 2461, -1, "Star", 1);// 17
			AddComplexComponent( (BaseAddon) this, 10231, -2, 0, 6, 2461, -1, "Star", 1);// 18
			AddComplexComponent( (BaseAddon) this, 10231, -1, 0, 6, 2461, -1, "Star", 1);// 19

		}

		public HedgeFlagEastAddon( Serial serial ) : base( serial )
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

	public class HedgeFlagEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new HedgeFlagEastAddon();
			}
		}

		[Constructable]
		public HedgeFlagEastAddonDeed()
		{
			Name = "HedgeFlagEast";
		}

		public HedgeFlagEastAddonDeed( Serial serial ) : base( serial )
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