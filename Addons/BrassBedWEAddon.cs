
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
	public class BrassBedWEAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BrassBedWEAddonDeed();
			}
		}

		[ Constructable ]
		public BrassBedWEAddon()
		{



			AddComplexComponent( (BaseAddon) this, 3125, 1, 0, 1, 2668, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 3125, 0, 0, 1, 2668, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 6421, 0, 0, 7, 2575, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 14719, 0, 0, 4, 1281, -1, "Brass Headboard", 1);// 4
			AddComplexComponent( (BaseAddon) this, 3124, 0, 1, 1, 2668, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 3123, 1, 1, 1, 2668, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 6421, 0, 1, 7, 2575, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 14719, 0, 1, 4, 1281, -1, "Brass Headboard", 1);// 8
			AddComplexComponent( (BaseAddon) this, 192, -1, 1, 1, 1281, -1, "Brass Headboard", 1);// 9
			AddComplexComponent( (BaseAddon) this, 7712, 1, 1, 6, 0, -1, "Sleeping Beauty", 1);// 10
			AddComplexComponent( (BaseAddon) this, 14719, 2, 0, 0, 1281, -1, "Brass FootBoard", 1);// 11
			AddComplexComponent( (BaseAddon) this, 14719, 2, 1, 0, 1281, -1, "Brass FootBoard", 1);// 12

		}

		public BrassBedWEAddon( Serial serial ) : base( serial )
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

	public class BrassBedWEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BrassBedWEAddon();
			}
		}

		[Constructable]
		public BrassBedWEAddonDeed()
		{
			Name = "BrassBedWE";
		}

		public BrassBedWEAddonDeed( Serial serial ) : base( serial )
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