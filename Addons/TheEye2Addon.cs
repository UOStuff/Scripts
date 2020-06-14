
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
	public class TheEye2Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {14120, 1, 1, 12}// 5	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TheEye2AddonDeed();
			}
		}

		[ Constructable ]
		public TheEye2Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 14000, 0, 0, 3, 2458, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 108, 1, -1, 4, 2458, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 108, 1, 1, 4, 2458, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 108, -1, 1, 4, 2458, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 108, -1, -1, 1, 2458, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 14238, 1, 1, 28, 2458, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 14327, 0, 2, 14, 2539, -1, "Skull", 1);// 8
			AddComplexComponent( (BaseAddon) this, 14327, 2, 0, 14, 2539, -1, "Skull", 1);// 9
			AddComplexComponent( (BaseAddon) this, 14327, 2, 2, 14, 2539, -1, "Skull", 1);// 10
			AddComplexComponent( (BaseAddon) this, 14327, -1, -1, 3, 2539, -1, "Skull", 1);// 11
			AddComplexComponent( (BaseAddon) this, 11655, 1, 1, 25, 2458, -1, "Eye", 1);// 12
			AddComplexComponent( (BaseAddon) this, 14217, 1, 1, 2, 2823, -1, "Vortex", 1);// 13
			AddComplexComponent( (BaseAddon) this, 14013, 0, 0, 0, 2458, -1, "", 1);// 14

		}

		public TheEye2Addon( Serial serial ) : base( serial )
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

	public class TheEye2AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TheEye2Addon();
			}
		}

		[Constructable]
		public TheEye2AddonDeed()
		{
			Name = "TheEye2";
		}

		public TheEye2AddonDeed( Serial serial ) : base( serial )
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