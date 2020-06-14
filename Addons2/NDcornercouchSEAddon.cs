
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
	public class NDcornercouchSEAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1824, -3, 2, 0}, {1824, -3, 3, 0}, {1824, -2, 3, 0}// 1	2	3	
			, {1824, -1, 3, 0}, {2861, -2, 2, 0}, {2861, -1, 2, 0}// 4	5	6	
			, {1824, 3, -3, 0}, {1824, 3, -2, 0}, {1824, 3, -1, 0}// 7	8	9	
			, {1824, 2, -3, 0}, {2860, 2, -2, 0}, {2860, 2, -1, 0}// 10	11	12	
			, {1824, 0, 3, 0}, {1824, 1, 3, 0}, {1824, 2, 3, 0}// 13	14	15	
			, {1824, 3, 3, 0}, {1824, 3, 0, 0}, {1824, 3, 1, 0}// 16	17	18	
			, {1824, 3, 2, 0}, {1824, 2, 2, 0}, {2860, 2, 0, 0}// 19	20	21	
			, {2860, 2, 1, 0}, {2861, 0, 2, 0}, {2861, 1, 2, 0}// 22	23	24	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new NDcornercouchSEAddonDeed();
			}
		}

		[ Constructable ]
		public NDcornercouchSEAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public NDcornercouchSEAddon( Serial serial ) : base( serial )
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

	public class NDcornercouchSEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new NDcornercouchSEAddon();
			}
		}

		[Constructable]
		public NDcornercouchSEAddonDeed()
		{
			Name = "NDcornercouchSE";
		}

		public NDcornercouchSEAddonDeed( Serial serial ) : base( serial )
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