
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
	public class lovearborAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3265, 3, 0, 0}, {3265, -3, 1, 0}// 11	17	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new lovearborAddonDeed();
			}
		}

		[ Constructable ]
		public lovearborAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 10079, -2, 0, 0, 2953, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 10079, 1, 0, 0, 2953, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 2861, -1, 0, 0, 2953, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2861, 0, 0, 0, 2953, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 2861, 1, 0, 0, 2953, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 3312, -1, 0, 2, 168, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 3312, 2, 0, 0, 168, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 3203, 2, 0, 1, 2673, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 3203, -3, 0, 0, 2673, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 11777, 1, 0, 19, 165, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 3211, 2, 1, 0, 2673, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 3211, -2, 1, 0, 2673, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 11777, 1, 1, 30, 165, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 11777, 0, 1, 29, 165, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 11777, -1, 1, 29, 165, -1, "", 1);// 16

		}

		public lovearborAddon( Serial serial ) : base( serial )
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

	public class lovearborAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new lovearborAddon();
			}
		}

		[Constructable]
		public lovearborAddonDeed()
		{
			Name = "lovearbor";
		}

		public lovearborAddonDeed( Serial serial ) : base( serial )
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