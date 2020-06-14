
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
	public class ladiesvanityAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3590, 1, 2, 17}// 7	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new ladiesvanityAddonDeed();
			}
		}

		[ Constructable ]
		public ladiesvanityAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 4604, 1, 0, 0, 2723, -1, "stool", 1);// 1
			AddComplexComponent( (BaseAddon) this, 3580, 0, -1, 6, 33, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 5396, 0, 0, 5, 2539, -1, "mirror", 1);// 3
			AddComplexComponent( (BaseAddon) this, 7618, 0, -1, 0, 2723, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 7617, 0, 1, 0, 2723, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 3619, 0, 0, 6, 2284, -1, "basin", 1);// 6
			AddComplexComponent( (BaseAddon) this, 7619, 0, 0, 0, 2723, -1, "", 1);// 8

		}

		public ladiesvanityAddon( Serial serial ) : base( serial )
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

	public class ladiesvanityAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new ladiesvanityAddon();
			}
		}

		[Constructable]
		public ladiesvanityAddonDeed()
		{
			Name = "ladiesvanity";
		}

		public ladiesvanityAddonDeed( Serial serial ) : base( serial )
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