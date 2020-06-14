
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
	public class coffeetablewesteast3Addon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new coffeetablewesteast3AddonDeed();
			}
		}

		[ Constructable ]
		public coffeetablewesteast3Addon()
		{



			AddComplexComponent( (BaseAddon) this, 280, -1, 1, 0, 0, -1, "Coffee Table", 1);// 1
			AddComplexComponent( (BaseAddon) this, 9311, -1, 0, 4, 0, -1, "Coffee Table", 1);// 2
			AddComplexComponent( (BaseAddon) this, 9313, -1, 1, 4, 0, -1, "Coffee Table", 1);// 3
			AddComplexComponent( (BaseAddon) this, 279, 1, 1, 0, 0, -1, "Coffee Table", 1);// 4
			AddComplexComponent( (BaseAddon) this, 280, 0, 1, 0, 0, -1, "Coffee Table", 1);// 5
			AddComplexComponent( (BaseAddon) this, 281, 1, 0, 0, 0, -1, "Coffee Table", 1);// 6
			AddComplexComponent( (BaseAddon) this, 9310, 1, 0, 4, 0, -1, "Coffee Table", 1);// 7
			AddComplexComponent( (BaseAddon) this, 9312, 1, 1, 4, 0, -1, "Coffee Table", 1);// 8
			AddComplexComponent( (BaseAddon) this, 9314, 0, 0, 4, 0, -1, "Coffee Table", 1);// 9
			AddComplexComponent( (BaseAddon) this, 9314, 0, 1, 4, 0, -1, "Coffee Table", 1);// 10

		}

		public coffeetablewesteast3Addon( Serial serial ) : base( serial )
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

	public class coffeetablewesteast3AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new coffeetablewesteast3Addon();
			}
		}

		[Constructable]
		public coffeetablewesteast3AddonDeed()
		{
			Name = "coffeetablewesteast3";
		}

		public coffeetablewesteast3AddonDeed( Serial serial ) : base( serial )
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