
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
	public class StoveWEAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new StoveWEAddonDeed();
			}
		}

		[ Constructable ]
		public StoveWEAddon()
		{



			AddComplexComponent( (BaseAddon) this, 1801, 0, 0, 0, 1150, -1, "Stove", 1);// 1
			AddComplexComponent( (BaseAddon) this, 281, -1, 0, 0, 1150, -1, "Stove", 1);// 2
			AddComplexComponent( (BaseAddon) this, 281, -1, 0, 3, 1150, -1, "Stove", 1);// 3
			AddComplexComponent( (BaseAddon) this, 281, -1, 0, 4, 1150, -1, "Control Panel", 1);// 4
			AddComplexComponent( (BaseAddon) this, 3878, 0, 1, 12, 1, -1, "Control Knob", 1);// 5
			AddComplexComponent( (BaseAddon) this, 3879, 0, 0, 11, 1, -1, "Control Knob", 1);// 6
			AddComplexComponent( (BaseAddon) this, 11025, 0, 0, 5, 1, -1, "Stove Burner", 1);// 7
			AddComplexComponent( (BaseAddon) this, 11024, 1, 1, 12, 1, -1, "Stove Burner", 1);// 8
			AddComplexComponent( (BaseAddon) this, 2550, 1, 0, 5, 1, -1, "Oven Door Handle", 1);// 9

		}

		public StoveWEAddon( Serial serial ) : base( serial )
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

	public class StoveWEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new StoveWEAddon();
			}
		}

		[Constructable]
		public StoveWEAddonDeed()
		{
			Name = "StoveWE";
		}

		public StoveWEAddonDeed( Serial serial ) : base( serial )
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