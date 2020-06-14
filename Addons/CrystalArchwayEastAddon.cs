
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
	public class CrystalArchwayEastAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {13804, 0, 3, 0}, {13804, 0, -2, 0}, {13815, 0, -1, 0}// 1	2	3	
			, {13815, 0, 2, 0}, {11513, 1, 2, 5}, {11513, 1, -1, 5}// 4	5	6	
			, {9036, 0, -1, 20}, {9036, 0, 0, 20}, {9036, 0, 1, 20}// 7	8	9	
			, {9036, 0, 2, 20}, {9037, 0, -1, 20}, {9037, 0, 0, 20}// 10	11	12	
			, {9037, 0, 1, 20}, {9037, 0, 2, 20}, {9037, 1, 2, 20}// 13	14	15	
			, {9037, 1, -1, 20}, {9036, 1, 2, 13}, {9036, 1, -1, 13}// 16	17	18	
			, {3224, 1, 2, 0}, {3224, 1, -1, 0}// 19	20	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CrystalArchwayEastAddonDeed();
			}
		}

		[ Constructable ]
		public CrystalArchwayEastAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public CrystalArchwayEastAddon( Serial serial ) : base( serial )
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

	public class CrystalArchwayEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CrystalArchwayEastAddon();
			}
		}

		[Constructable]
		public CrystalArchwayEastAddonDeed()
		{
			Name = "CrystalArchwayEast";
		}

		public CrystalArchwayEastAddonDeed( Serial serial ) : base( serial )
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