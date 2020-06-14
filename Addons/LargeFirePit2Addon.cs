
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
	public class LargeFirePit2Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {9536, -1, 0, 0}, {9538, 0, -1, 0}, {9540, -1, 2, 0}// 1	2	3	
			, {9547, 1, -2, 0}, {9552, -2, 1, 0}, {9553, -1, 2, 0}// 4	5	6	
			, {9548, 2, -1, 0}, {9545, 2, -1, 0}, {13658, 2, 0, 0}// 7	8	9	
			, {13658, 1, 1, 0}, {13658, 0, 2, 0}, {11090, -1, 2, 0}// 10	11	12	
			, {11090, -1, 1, 0}, {11090, -1, 0, 0}, {11090, 0, -1, 0}// 13	14	15	
			, {11090, 1, -1, 0}, {11090, 2, -1, 0}, {12936, 1, 0, 0}// 16	17	18	
			, {12936, 0, 1, 0}, {12946, 0, 0, 0}, {2421, 1, -1, 1}// 19	20	25	
			, {2416, 1, -1, 9}, {7857, -1, 3, 0}, {7858, 3, -1, 0}// 26	27	28	
			, {7129, 3, -1, 2}, {7134, -1, 3, 0}, {7134, -1, 3, 1}// 29	30	31	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new LargeFirePit2AddonDeed();
			}
		}

		[ Constructable ]
		public LargeFirePit2Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 3555, 1, -1, 0, 0, 1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 3555, -1, 1, 0, 0, 1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 14732, 0, 0, 0, 0, 1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 14742, 0, 0, 0, 0, 1, "", 1);// 24

		}

		public LargeFirePit2Addon( Serial serial ) : base( serial )
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

	public class LargeFirePit2AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new LargeFirePit2Addon();
			}
		}

		[Constructable]
		public LargeFirePit2AddonDeed()
		{
			Name = "LargeFirePit2";
		}

		public LargeFirePit2AddonDeed( Serial serial ) : base( serial )
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