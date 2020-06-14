/////////////////////////////////////////////////
//
// Automatically generated by the
// AddonGenerator script by Arya
//
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class Hall2011Tabl2Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Hall2011Tabl2AddonDeed();
			}
		}

		[ Constructable ]
		public Hall2011Tabl2Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 2868 );
			ac.Hue = 1150;
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 2868 );
			ac.Hue = 1150;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 4623 );
			AddComponent( ac, 0, -1, 5 );
			ac = new AddonComponent( 4629 );
			AddComponent( ac, -1, 0, 5 );
			ac = new AddonComponent( 4626 );
			AddComponent( ac, 1, 1, 5 );
			ac = new AddonComponent( 4630 );
			AddComponent( ac, 0, 0, 5 );
			ac = new AddonComponent( 4627 );
			AddComponent( ac, 0, 1, 5 );
			ac = new AddonComponent( 4624 );
			AddComponent( ac, 1, -1, 5 );
			ac = new AddonComponent( 4628 );
			AddComponent( ac, -1, 1, 5 );
			ac = new AddonComponent( 4625 );
			AddComponent( ac, 1, 0, 5 );
			ac = new AddonComponent( 4622 );
			AddComponent( ac, -1, -1, 5 );
			ac = new AddonComponent( 4012 );
			ac.Light = LightType.ArchedWindowEast;
			AddComponent( ac, 1, 1, 17 );
			ac = new AddonComponent( 6571 );
			ac.Light = LightType.ArchedWindowEast;
			AddComponent( ac, 1, 1, 20 );
			ac = new AddonComponent( 7811 );
			AddComponent( ac, 0, 1, 14 );
			ac = new AddonComponent( 7812 );
			AddComponent( ac, 1, 0, 15 );
			ac = new AddonComponent( 7811 );
			AddComponent( ac, 1, 0, 6 );
			ac = new AddonComponent( 7812 );
			AddComponent( ac, 0, 1, 5 );
			ac = new AddonComponent( 2493 );
			ac.Hue = 1157;
			AddComponent( ac, 0, 1, 15 );
			ac = new AddonComponent( 2517 );
			ac.Hue = 1157;
			AddComponent( ac, 1, 0, 6 );
			ac = new AddonComponent( 2516 );
			ac.Hue = 1157;
			AddComponent( ac, 0, 1, 5 );
			ac = new AddonComponent( 2494 );
			ac.Hue = 1157;
			AddComponent( ac, 0, -1, 5 );

		}

		public Hall2011Tabl2Addon( Serial serial ) : base( serial )
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

	public class Hall2011Tabl2AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Hall2011Tabl2Addon();
			}
		}

		[Constructable]
		public Hall2011Tabl2AddonDeed()
		{
			Name = "Hall2011Tabl2";
		}

		public Hall2011Tabl2AddonDeed( Serial serial ) : base( serial )
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