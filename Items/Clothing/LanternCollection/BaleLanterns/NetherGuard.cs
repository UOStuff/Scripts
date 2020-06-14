using System;
using Server;

namespace Server.Items
{
    public class NetherGuard : MetalShield
    {
        public override int BasePhysicalResistance{ get{ return 15; } }
        public override int BasePoisonResistance { get { return 15; } }
        public override int BaseColdResistance { get { return 15; } }
        public override int BaseEnergyResistance { get { return 15; } }
		public override int BaseFireResistance{ get{ return 0; } }
        public override int ArtifactRarity{ get{ return 15; } }
        public override int InitMinHits{ get{ return 255; } }
        public override int InitMaxHits{ get{ return 255; } }

        [Constructable]
        public NetherGuard()
        {
            Name = "-Nether Guard-";
			ItemID = 2597;
            Hue = Utility.RandomList( 97, 2051, 2020, 1107, 1758, 2106 );
            StrRequirement = 15;
            Attributes.BonusStr = 10;
            Attributes.BonusInt = 10;
            Attributes.BonusDex = 10;
            Attributes.SpellChanneling = 1;
            Attributes.NightSight = 1;
            Attributes.AttackChance = 5;
            Attributes.DefendChance = 15;
			Attributes.ReflectPhysical = 15;
            Attributes.Luck = 150;
            ArmorAttributes.SelfRepair = 3;
            SkillBonuses.SetValues(0, SkillName.Necromancy, 10.0);
            Light = LightType.Circle300;
            
        }

        public NetherGuard(Serial serial) : base( serial )
        {
        }

		public override void OnDoubleClick( Mobile from )
		{
			if ( !IsChildOf( from.Backpack ) )
			{
				from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
			}

			else
			{

				if ( this.ItemID == 2597 )
				{
					this.ItemID = 2594;
				}
				else if ( this.ItemID == 2594 )
				{
					this.ItemID = 2597;
				}
				else if (this.ItemID != 2597 || this.ItemID != 2594 )
				{
					from.SendMessage("There was a problem lighting your lantern. Please contact a staff member");				
				}
				else
				{
					from.SendMessage( "Your lantern is broken. Please contact a staff member to repair it!" );
				}
			}
		}
		
        public override void Serialize( GenericWriter writer )
        {
            base.Serialize( writer );
            writer.Write( (int) 0 );
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize( reader );
            int version = reader.ReadInt();
        }
    } // End Class
} // End Namespace
