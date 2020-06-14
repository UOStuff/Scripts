
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
	public class trashpileAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {7074, -2, 2, 1}, {7075, -2, 1, 1}, {7082, 0, -2, 1}// 1	 2	 3	 
			, {7077, -2, -1, 1}, {7081, -1, -2, 1}, {7090, 1, 1, 1}// 4	 5	 6	 
			, {7071, 1, 2, 1}, {7078, -1, 1, 1}, {7073, -1, 2, 1}// 7	 8	 9	 
			, {7080, -1, -1, 1}, {7085, 1, -2, 1}, {7084, 1, -1, 1}// 10	 11	 12	 
			, {7083, 0, -1, 1}, {7088, 2, 0, 1}, {7086, 2, -2, 1}// 13	 14	 15	 
			, {7076, -2, 0, 1}, {7079, -1, 0, 1}, {7072, 0, 2, 1}// 16	 17	 18	 
			, {3247, 0, 2, 0}, {7087, 2, -1, 1}// 19	 20	 
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new trashpileAddonDeed();
			}
		}

		[ Constructable ]
		public trashpileAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public trashpileAddon( Serial serial ) : base( serial )
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

	public class trashpileAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new trashpileAddon();
			}
		}

		[Constructable]
		public trashpileAddonDeed()
		{
			Name = "trashpile";
		}

		public trashpileAddonDeed( Serial serial ) : base( serial )
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