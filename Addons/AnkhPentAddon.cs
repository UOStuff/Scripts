
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
	public class AnkhPentAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4, 0, -2, 0}, {2, -2, 1, 0}, {3, -2, 0, 0}// 1	2	3	
			, {4071, -1, -1, 0}, {4072, 0, -1, 0}, {4070, -1, 0, 0}// 4	5	6	
			, {4074, 0, 0, 0}, {4073, -1, 1, 0}, {4076, 0, 1, 0}// 7	8	9	
			, {7380, 0, 2, 2}, {7405, 0, 0, 0}, {7373, -1, 2, 2}// 12	14	15	
			, {4311, -1, 1, 0}, {5, 1, -2, 0}, {4075, 1, -1, 0}// 16	17	18	
			, {4078, 1, 0, 0}, {4077, 1, 1, 0}, {7384, 2, 0, 2}// 19	20	21	
			, {7374, 1, 2, 2}, {7374, 2, 1, 2}, {7376, 2, -1, 2}// 23	24	25	
			, {4653, 2, 1, 0}, {4651, 1, 2, 0}, {4650, 1, 1, 0}// 26	27	28	
			, {4310, 1, -1, 0}// 29	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AnkhPentAddonDeed();
			}
		}

		[ Constructable ]
		public AnkhPentAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 6570, -1, -1, 0, 0, 10, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 3555, -1, -1, 17, 0, 10, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 6228, -2, 1, 7, 0, 10, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 6228, 1, -2, 7, 0, 10, "", 1);// 22

		}

		public AnkhPentAddon( Serial serial ) : base( serial )
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

	public class AnkhPentAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AnkhPentAddon();
			}
		}

		[Constructable]
		public AnkhPentAddonDeed()
		{
			Name = "AnkhPent";
		}

		public AnkhPentAddonDeed( Serial serial ) : base( serial )
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