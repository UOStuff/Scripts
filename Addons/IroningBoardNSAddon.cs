
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
	public class IroningBoardNSAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new IroningBoardNSAddonDeed();
			}
		}

		[ Constructable ]
		public IroningBoardNSAddon()
		{



			AddComplexComponent( (BaseAddon) this, 6649, 0, 1, 0, 0, -1, "Ironing Board", 1);// 1
			AddComplexComponent( (BaseAddon) this, 6650, 0, 0, 0, 0, -1, "Ironing Board", 1);// 2
			AddComplexComponent( (BaseAddon) this, 4144, 0, 0, 6, 1150, -1, "Iron", 1);// 3
			AddComplexComponent( (BaseAddon) this, 8974, 0, 1, 7, 1150, -1, "", 1);// 4

		}

		public IroningBoardNSAddon( Serial serial ) : base( serial )
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

	public class IroningBoardNSAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new IroningBoardNSAddon();
			}
		}

		[Constructable]
		public IroningBoardNSAddonDeed()
		{
			Name = "IroningBoardNS";
		}

		public IroningBoardNSAddonDeed( Serial serial ) : base( serial )
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