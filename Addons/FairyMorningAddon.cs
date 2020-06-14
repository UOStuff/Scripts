
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
	public class FairyMorningAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3208, 1, 1, 0}, {3208, 0, 1, 0}, {3210, 0, -1, 0}// 1	3	6	
			, {3204, 1, -1, 0}, {3208, 1, 0, 0}, {3204, -2, 1, 0}// 7	9	12	
			, {3237, -1, 1, 0}, {3210, -2, 0, 0}, {3206, -1, -1, 0}// 13	15	16	
			, {9678, 0, 2, 2}, {9632, -2, 2, 3}// 23	24	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new FairyMorningAddonDeed();
			}
		}

		[ Constructable ]
		public FairyMorningAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 9654, 0, 0, 10, 0, -1, "a shrunken pet", 1);// 2
			AddComplexComponent( (BaseAddon) this, 3237, -1, 0, 0, 246, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 3342, 2, 0, 0, 237, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 3345, -1, 1, 0, 237, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 8750, 0, 0, 0, 422, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 3344, -1, 0, 0, 237, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 3341, 0, -1, 0, 237, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 3343, 0, 1, 0, 237, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 8751, 0, -2, 0, 382, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 8752, 1, -2, 0, 404, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 3220, -2, -1, 0, 295, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 3220, -1, -2, 0, 221, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 3220, -2, -2, 0, 234, -1, "", 1);// 22

		}

		public FairyMorningAddon( Serial serial ) : base( serial )
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

	public class FairyMorningAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new FairyMorningAddon();
			}
		}

		[Constructable]
		public FairyMorningAddonDeed()
		{
			Name = "FairyMorning";
		}

		public FairyMorningAddonDeed( Serial serial ) : base( serial )
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