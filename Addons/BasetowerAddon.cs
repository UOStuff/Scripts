
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
	public class BasetowerAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {536, -1, 1, 0}, {535, -1, 0, 0}, {535, -1, 0, 20}// 1	2	3	
			, {536, -1, 1, 20}, {535, -1, 0, 40}, {536, -1, 1, 40}// 4	5	6	
			, {532, 1, 2, 0}, {533, 0, 2, 0}, {530, 0, -1, 0}// 7	8	9	
			, {531, 1, -1, 0}, {537, 2, 0, 0}, {527, 2, 1, 0}// 10	11	12	
			, {530, 0, -1, 20}, {531, 1, -1, 20}, {533, 0, 2, 20}// 13	14	15	
			, {537, 2, 0, 20}, {532, 1, 2, 20}, {527, 2, 1, 20}// 16	17	18	
			, {530, 0, -1, 40}, {531, 1, -1, 40}, {533, 0, 2, 40}// 19	20	21	
			, {537, 2, 0, 40}, {532, 1, 2, 40}, {527, 2, 1, 40}// 22	23	24	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BasetowerAddonDeed();
			}
		}

		[ Constructable ]
		public BasetowerAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public BasetowerAddon( Serial serial ) : base( serial )
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

	public class BasetowerAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BasetowerAddon();
			}
		}

		[Constructable]
		public BasetowerAddonDeed()
		{
			Name = "Basetower";
		}

		public BasetowerAddonDeed( Serial serial ) : base( serial )
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