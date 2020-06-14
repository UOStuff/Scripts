
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
	public class zoocageEAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1822, -3, 5, 0}, {1822, -3, 5, 5}, {1822, -3, 5, 10}// 1	2	3	
			, {1822, -3, 5, 15}, {2083, -2, 5, 0}, {2083, -2, -4, 0}// 4	5	6	
			, {1822, -3, -3, 0}, {1822, -3, -3, 5}, {1822, -3, -3, 10}// 7	8	9	
			, {1822, -3, -3, 15}, {2081, -4, -2, 0}, {2081, -4, -1, 0}// 10	11	12	
			, {2081, -4, 0, 0}, {2081, -4, 1, 0}, {2081, -4, 2, 0}// 13	14	15	
			, {2081, -4, 3, 0}, {2081, -4, 4, 0}, {2081, 4, -1, 0}// 16	17	18	
			, {2081, 4, 0, 0}, {2081, 4, 3, 0}, {2081, 4, 4, 0}// 19	20	21	
			, {1822, 4, -3, 0}, {1822, 4, -3, 5}, {1822, 4, -3, 10}// 22	23	24	
			, {1822, 4, -3, 15}, {1822, 4, 5, 0}, {1822, 4, 5, 5}// 25	26	27	
			, {1822, 4, 5, 10}, {1822, 4, 5, 15}, {2083, -1, 5, 0}// 28	29	30	
			, {2083, 0, 5, 0}, {2083, 1, 5, 0}, {2083, 2, 5, 0}// 31	32	33	
			, {2083, 3, 5, 0}, {2083, -1, -4, 0}, {2083, 0, -4, 0}// 34	35	36	
			, {2083, 1, -4, 0}, {2083, 2, -4, 0}, {2083, 3, -4, 0}// 37	38	39	
			, {2081, 4, -2, 0}, {2081, 4, 2, 0}// 40	41	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new zoocageEAddonDeed();
			}
		}

		[ Constructable ]
		public zoocageEAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public zoocageEAddon( Serial serial ) : base( serial )
		{
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

	public class zoocageEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new zoocageEAddon();
			}
		}

		[Constructable]
		public zoocageEAddonDeed()
		{
			Name = "zoocageE";
		}

		public zoocageEAddonDeed( Serial serial ) : base( serial )
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