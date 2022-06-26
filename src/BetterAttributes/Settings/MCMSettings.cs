﻿using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Dropdown;
using MCM.Abstractions.Settings.Base.Global;

namespace BetterAttributes.Settings {

    internal class MCMSettings : AttributeGlobalSettings<MCMSettings>, ISettings {

        const string bonusesText = "{=BA_oPw9hh}Bonuses";

        const string enabledText = "{=BA_V8krxN}Enabled?";
        const string enabledDesText = "{=BA_sVRwEA}Should bonuses be applied.";

        const string playerOnlyText = "{=BA_vBH4P5}Player Only";
        const string playerOnlyDesText = "{=BA_5AKRK0}Determines if this bonus applies to all heroes, not just the player.";

        const string bonusText = "{=BA_8g0U40}Bonus Percent";
        const string genericBonusText = "{=BA_3F0Jal}A percent increase multiplied by attribute level. (For example, a .02 bonus will be 20% at attribute level 10)";

        const string attributeText = "{BA_OUkZom}Attribute";
        const string genericAtrSelectText = "{=BA_N7DNB0}Select the attribute that this bonus should use";

        const string vigorText = "{=BA_Mf0D9r}Vigor";
        const string controlText = "{=BA_yXzbqm}Control";
        const string enduranceText = "{=BA_3xcrKW}Endurance";
        const string cunningText = "{=BA_v92Ex5}Cunning";
        const string socialText = "{=BA_YtXewV}Social";
        const string intelligenceText = "{=BA_i0FVps}Intelligence";


        const string meleeText = "{=BA_YdzGi4}Melee Damage Bonus";

        [SettingPropertyGroup(bonusesText + "/" + meleeText)]
        [SettingPropertyBool(enabledText, Order = 0, RequireRestart = false, IsToggle = true, HintText = enabledDesText)]
        public bool melDmgBonusEnabled { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + meleeText)]
        [SettingPropertyBool(playerOnlyText, Order = 0, RequireRestart = false, HintText = playerOnlyDesText)]
        public bool melDmgBonusPlayerOnly { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + meleeText)]
        [SettingPropertyFloatingInteger(bonusText, 0f, 10f, "0.00", Order = 0, RequireRestart = false, HintText = genericBonusText)]
        public float melDmgBonus { get; set; } = .02f;

        [SettingPropertyGroup(bonusesText + "/" + meleeText)]
        [SettingPropertyDropdown(attributeText, Order = 0, RequireRestart = false, HintText = genericAtrSelectText)]
        public DropdownDefault<string> melDmgBonusAttributeDropdown { get; set; } = new DropdownDefault<string>(new string[] {
            vigorText,
            controlText,
            enduranceText,
            cunningText,
            socialText,
            intelligenceText
        }, selectedIndex: 0);


        const string rangeText = "{=BA_qDobnE}Range Damage Bonus";

        [SettingPropertyGroup(bonusesText + "/" + rangeText)]
        [SettingPropertyBool(enabledText, Order = 0, RequireRestart = false, IsToggle = true, HintText = enabledDesText)]
        public bool rngDmgBonusEnabled { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + rangeText)]
        [SettingPropertyBool(playerOnlyText, Order = 0, RequireRestart = false, HintText = playerOnlyDesText)]
        public bool rngDmgBonusPlayerOnly { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + rangeText)]
        [SettingPropertyFloatingInteger(bonusText, 0f, 10f, "0.00", Order = 0, RequireRestart = false, HintText = genericBonusText)]
        public float rngDmgBonus { get; set; } = .02f;

        [SettingPropertyGroup(bonusesText + "/" + rangeText)]
        [SettingPropertyDropdown(attributeText, Order = 0, RequireRestart = false, HintText = genericAtrSelectText)]
        public DropdownDefault<string> rngDmgBonusAttributeDropdown { get; set; } = new DropdownDefault<string>(new string[] {
            vigorText,
            controlText,
            enduranceText,
            cunningText,
            socialText,
            intelligenceText
        }, selectedIndex: 1);


        const string healthText = "{=BA_naGmUB}Health Bonus";

        [SettingPropertyGroup(bonusesText + "/" + healthText)]
        [SettingPropertyBool(enabledText, Order = 0, RequireRestart = false, IsToggle = true, HintText = enabledDesText)]
        public bool healthBonusEnabled { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + healthText)]
        [SettingPropertyBool(playerOnlyText, Order = 0, RequireRestart = false, HintText = playerOnlyDesText)]
        public bool healthBonusPlayerOnly { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + healthText)]
        [SettingPropertyFloatingInteger(bonusText, 0f, 10f, "0.00", Order = 0, RequireRestart = false, HintText = genericBonusText)]
        public float healthBonus { get; set; } = .02f;

        [SettingPropertyGroup(bonusesText + "/" + healthText)]
        [SettingPropertyDropdown(attributeText, Order = 0, RequireRestart = false, HintText = genericAtrSelectText)]
        public DropdownDefault<string> healthBonusAttributeDropdown { get; set; } = new DropdownDefault<string>(new string[] {
            vigorText,
            controlText,
            enduranceText,
            cunningText,
            socialText,
            intelligenceText
        }, selectedIndex: 2);


        const string staggerText = "{=BA_ZYM5T1}Stagger Interrupt Bonus";

        [SettingPropertyGroup(bonusesText + "/" + staggerText)]
        [SettingPropertyBool(enabledText, Order = 0, RequireRestart = false, IsToggle = true, HintText = enabledDesText)]
        public bool staggerBonusEnabled { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + staggerText)]
        [SettingPropertyBool(playerOnlyText, Order = 0, RequireRestart = false, HintText = playerOnlyDesText)]
        public bool staggerBonusPlayerOnly { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + staggerText)]
        [SettingPropertyFloatingInteger(bonusText, 0f, 10f, "0.00", Order = 0, RequireRestart = false, HintText = genericBonusText)]
        public float staggerBonus { get; set; } = .02f;

        [SettingPropertyGroup(bonusesText + "/" + staggerText)]
        [SettingPropertyDropdown(attributeText, Order = 0, RequireRestart = false, HintText = genericAtrSelectText)]
        public DropdownDefault<string> staggerBonusAttributeDropdown { get; set; } = new DropdownDefault<string>(new string[] {
            vigorText,
            controlText,
            enduranceText,
            cunningText,
            socialText,
            intelligenceText
        }, selectedIndex: 2);


        const string simText = "{=BA_7yzj1P}Simulation Bonus";

        [SettingPropertyGroup(bonusesText + "/" + simText)]
        [SettingPropertyBool(enabledText, Order = 0, RequireRestart = false, IsToggle = true, HintText = enabledDesText)]
        public bool simBonusEnabled { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + simText)]
        [SettingPropertyBool(playerOnlyText, Order = 0, RequireRestart = false, HintText = playerOnlyDesText)]
        public bool simBonusPlayerOnly { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + simText)]
        [SettingPropertyFloatingInteger(bonusText, 0f, 10f, "0.00", Order = 0, RequireRestart = false, HintText = genericBonusText)]
        public float simBonus { get; set; } = .02f;

        [SettingPropertyGroup(bonusesText + "/" + simText)]
        [SettingPropertyDropdown(attributeText, Order = 0, RequireRestart = false, HintText = genericAtrSelectText)]
        public DropdownDefault<string> simBonusAttributeDropdown { get; set; } = new DropdownDefault<string>(new string[] {
            vigorText,
            controlText,
            enduranceText,
            cunningText,
            socialText,
            intelligenceText
        }, selectedIndex: 3);


        const string persuasionText = "{=BA_zH5MWH}Persuasion Bonus";

        [SettingPropertyGroup(bonusesText + "/" + persuasionText)]
        [SettingPropertyBool(enabledText, Order = 0, RequireRestart = false, IsToggle = true, HintText = enabledDesText)]
        public bool persuasionBonusEnabled { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + persuasionText)]
        [SettingPropertyFloatingInteger(bonusText, 0f, 10f, "0.00", Order = 0, RequireRestart = false, HintText = genericBonusText)]
        public float persuasionBonus { get; set; } = .02f;

        [SettingPropertyGroup(bonusesText + "/" + persuasionText)]
        [SettingPropertyDropdown(attributeText, Order = 0, RequireRestart = false, HintText = genericAtrSelectText)]
        public DropdownDefault<string> persuasionBonusAttributeDropdown { get; set; } = new DropdownDefault<string>(new string[] {
            vigorText,
            controlText,
            enduranceText,
            cunningText,
            socialText,
            intelligenceText
        }, selectedIndex: 3);


        const string renownText = "{=BA_z99bZB}Renown Bonus From Victories";

        [SettingPropertyGroup(bonusesText + "/" + renownText)]
        [SettingPropertyBool(enabledText, Order = 0, RequireRestart = false, IsToggle = true, HintText = enabledDesText)]
        public bool renownBonusEnabled { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + renownText)]
        [SettingPropertyBool(playerOnlyText, Order = 0, RequireRestart = false, HintText = playerOnlyDesText)]
        public bool renownBonusPlayerOnly { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + renownText)]
        [SettingPropertyFloatingInteger(bonusText, 0f, 10f, "0.00", Order = 0, RequireRestart = false, HintText = genericBonusText)]
        public float renownBonus { get; set; } = .02f;

        [SettingPropertyGroup(bonusesText + "/" + renownText)]
        [SettingPropertyDropdown(attributeText, Order = 0, RequireRestart = false, HintText = genericAtrSelectText)]
        public DropdownDefault<string> renownBonusAttributeDropdown { get; set; } = new DropdownDefault<string>(new string[] {
            vigorText,
            controlText,
            enduranceText,
            cunningText,
            socialText,
            intelligenceText
        }, selectedIndex: 3);


        const string moralText = "{=BA_GaAeaG}Morale Bonus From Victories";

        [SettingPropertyGroup(bonusesText + "/" + moralText)]
        [SettingPropertyBool(enabledText, Order = 0, RequireRestart = false, IsToggle = true, HintText = enabledDesText)]
        public bool moraleBonusEnabled { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + moralText)]
        [SettingPropertyBool(playerOnlyText, Order = 0, RequireRestart = false, HintText = playerOnlyDesText)]
        public bool moraleBonusPlayerOnly { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + moralText)]
        [SettingPropertyFloatingInteger(bonusText, 0f, 10f, "0.00", Order = 0, RequireRestart = false, HintText = genericBonusText)]
        public float moraleBonus { get; set; } = .02f;

        [SettingPropertyGroup(bonusesText + "/" + moralText)]
        [SettingPropertyDropdown(attributeText, Order = 0, RequireRestart = false, HintText = genericAtrSelectText)]
        public DropdownDefault<string> moraleBonusAttributeDropdown { get; set; } = new DropdownDefault<string>(new string[] {
            vigorText,
            controlText,
            enduranceText,
            cunningText,
            socialText,
            intelligenceText
        }, selectedIndex: 3);


        const string partyMoralText = "{=BA_WODJA5}Party Morale Bonus";

        [SettingPropertyGroup(bonusesText + "/" + partyMoralText)]
        [SettingPropertyBool(enabledText, Order = 0, RequireRestart = false, IsToggle = true, HintText = enabledDesText)]
        public bool partyMoraleBonusEnabled { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + partyMoralText)]
        [SettingPropertyBool(playerOnlyText, Order = 0, RequireRestart = false, HintText = playerOnlyDesText)]
        public bool partyMoraleBonusPlayerOnly { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + partyMoralText)]
        [SettingPropertyFloatingInteger(bonusText, 0f, 10f, "0.00", Order = 0, RequireRestart = false, HintText = genericBonusText)]
        public float partyMoraleBonus { get; set; } = .02f;

        [SettingPropertyGroup(bonusesText + "/" + partyMoralText)]
        [SettingPropertyDropdown(attributeText, Order = 0, RequireRestart = false, HintText = genericAtrSelectText)]
        public DropdownDefault<string> partyMoraleBonusAttributeDropdown { get; set; } = new DropdownDefault<string>(new string[] {
            vigorText,
            controlText,
            enduranceText,
            cunningText,
            socialText,
            intelligenceText
        }, selectedIndex: 4);


        const string wageText = "{=BA_6Eyxyw}Party Wage Reduction Bonus";

        [SettingPropertyGroup(bonusesText + "/" + wageText)]
        [SettingPropertyBool(enabledText, Order = 0, RequireRestart = false, IsToggle = true, HintText = enabledDesText)]
        public bool wageBonusEnabled { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + wageText)]
        [SettingPropertyBool(playerOnlyText, Order = 0, RequireRestart = false, HintText = playerOnlyDesText)]
        public bool wageBonusPlayerOnly { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + wageText)]
        [SettingPropertyFloatingInteger(bonusText, 0f, 10f, "0.00", Order = 0, RequireRestart = false, HintText = genericBonusText)]
        public float wageBonus { get; set; } = .02f;

        [SettingPropertyGroup(bonusesText + "/" + wageText)]
        [SettingPropertyDropdown(attributeText, Order = 0, RequireRestart = false, HintText = genericAtrSelectText)]
        public DropdownDefault<string> wageBonusAttributeDropdown { get; set; } = new DropdownDefault<string>(new string[] {
            vigorText,
            controlText,
            enduranceText,
            cunningText,
            socialText,
            intelligenceText
        }, selectedIndex: 4);


        const string sizeText = "{=BA_dka4CP}Party Size Bonus";

        [SettingPropertyGroup(bonusesText + "/" + sizeText)]
        [SettingPropertyBool(enabledText, Order = 0, RequireRestart = false, IsToggle = true, HintText = enabledDesText)]
        public bool partySizeBonusEnabled { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + sizeText)]
        [SettingPropertyBool(playerOnlyText, Order = 0, RequireRestart = false, HintText = playerOnlyDesText)]
        public bool partySizeBonusPlayerOnly { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + sizeText)]
        [SettingPropertyFloatingInteger(bonusText, 0f, 10f, "0.00", Order = 0, RequireRestart = false, HintText = genericBonusText)]
        public float partySizeBonus { get; set; } = .02f;

        [SettingPropertyGroup(bonusesText + "/" + sizeText)]
        [SettingPropertyDropdown(attributeText, Order = 0, RequireRestart = false, HintText = genericAtrSelectText)]
        public DropdownDefault<string> partySizeBonusAttributeDropdown { get; set; } = new DropdownDefault<string>(new string[] {
            vigorText,
            controlText,
            enduranceText,
            cunningText,
            socialText,
            intelligenceText
        }, selectedIndex: 4);



        const string incomeText = "{=BA_GINfAP}Clan Income Bonus";

        [SettingPropertyGroup(bonusesText + "/" + incomeText)]
        [SettingPropertyBool(enabledText, Order = 0, RequireRestart = false, IsToggle = true, HintText = enabledDesText)]
        public bool incomeBonusEnabled { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + incomeText)]
        [SettingPropertyBool(playerOnlyText, Order = 0, RequireRestart = false, HintText = playerOnlyDesText)]
        public bool incomeBonusPlayerOnly { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + incomeText)]
        [SettingPropertyFloatingInteger(bonusText, 0f, 10f, "0.00", Order = 0, RequireRestart = false, HintText = genericBonusText)]
        public float incomeBonus { get; set; } = .02f;

        [SettingPropertyGroup(bonusesText + "/" + incomeText)]
        [SettingPropertyDropdown(attributeText, Order = 0, RequireRestart = false, HintText = genericAtrSelectText)]
        public DropdownDefault<string> incomeBonusAttributeDropdown { get; set; } = new DropdownDefault<string>(new string[] {
            vigorText,
            controlText,
            enduranceText,
            cunningText,
            socialText,
            intelligenceText
        }, selectedIndex: 5);


        const string influenceText = "{=BA_5bULNj}Influence Bonus From Victories";

        [SettingPropertyGroup(bonusesText + "/" + influenceText)]
        [SettingPropertyBool(enabledText, Order = 0, RequireRestart = false, IsToggle = true, HintText = enabledDesText)]
        public bool influenceBonusEnabled { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + influenceText)]
        [SettingPropertyBool(playerOnlyText, Order = 0, RequireRestart = false, HintText = playerOnlyDesText)]
        public bool influenceBonusPlayerOnly { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + influenceText)]
        [SettingPropertyFloatingInteger(bonusText, 0f, 10f, "0.00", Order = 0, RequireRestart = false, HintText = genericBonusText)]
        public float influenceBonus { get; set; } = .02f;

        [SettingPropertyGroup(bonusesText + "/" + influenceText)]
        [SettingPropertyDropdown(attributeText, Order = 0, RequireRestart = false, HintText = genericAtrSelectText)]
        public DropdownDefault<string> influenceBonusAttributeDropdown { get; set; } = new DropdownDefault<string>(new string[] {
            vigorText,
            controlText,
            enduranceText,
            cunningText,
            socialText,
            intelligenceText
        }, selectedIndex: 5);


        const string xpText = "{=BA_35dS0f}XP Bonus";

        [SettingPropertyGroup(bonusesText + "/" + xpText)]
        [SettingPropertyBool(enabledText, Order = 0, RequireRestart = false, IsToggle = true, HintText = enabledDesText)]
        public bool xpBonusEnabled { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + xpText)]
        [SettingPropertyBool(playerOnlyText, Order = 0, RequireRestart = false, HintText = playerOnlyDesText)]
        public bool xpBonusPlayerOnly { get; set; } = true;

        [SettingPropertyGroup(bonusesText + "/" + xpText)]
        [SettingPropertyFloatingInteger(bonusText, 0f, 10f, "0.00", Order = 0, RequireRestart = false, HintText = genericBonusText)]
        public float xpBonus { get; set; } = .02f;

        [SettingPropertyGroup(bonusesText + "/" + xpText)]
        [SettingPropertyDropdown(attributeText, Order = 0, RequireRestart = false, HintText = genericAtrSelectText)]
        public DropdownDefault<string> xpBonusAttributeDropdown { get; set; } = new DropdownDefault<string>(new string[] {
            vigorText,
            controlText,
            enduranceText,
            cunningText,
            socialText,
            intelligenceText
        }, selectedIndex: 5);


        [SettingPropertyGroup(attributeText)]
        [SettingPropertyInteger("{=BA_GU6Ibm}Levels Per Attribute Points", 0, 10, "0", Order = 0, RequireRestart = false, HintText = "{=BA_VhEAx3}How many levels you need to gain to get an attribute point.")]
        public int levelsPerAttributePoint { get; set; } = 3;

        [SettingPropertyGroup(attributeText)]
        [SettingPropertyInteger("{=BA_KAggxW}Max Attribute Level", 0, 100, "0", Order = 0, RequireRestart = false, HintText = "{=BA_TAtfSS}Maximum level for attributes.")]
        public int maxAttributeLevel { get; set; } = 11;

        [SettingPropertyGroup("Focus")]
        [SettingPropertyInteger("{=BA_S7nfeK}Focus Points Per Level", 0, 10, "0", Order = 0, RequireRestart = false, HintText = "{=BA_GtIuji}How many focus points per level.")]
        public int focusPointsPerLevel { get; set; } = 1;



        public string melDmgBonusAttribute {
            get {
                return this.melDmgBonusAttributeDropdown.SelectedValue;
            }
            set {
                this.melDmgBonusAttributeDropdown.SelectedValue = value;
            }
        }

        public string rngDmgBonusAttribute {
            get {
                return this.rngDmgBonusAttributeDropdown.SelectedValue;
            }
            set {
                this.rngDmgBonusAttributeDropdown.SelectedValue = value;
            }
        }

        public string healthBonusAttribute {
            get {
                return this.healthBonusAttributeDropdown.SelectedValue;
            }
            set {
                this.healthBonusAttributeDropdown.SelectedValue = value;
            }
        }

        public string staggerBonusAttribute {
            get {
                return this.staggerBonusAttributeDropdown.SelectedValue;
            }
            set {
                this.staggerBonusAttributeDropdown.SelectedValue = value;
            }
        }

        public string simBonusAttribute {
            get {
                return this.simBonusAttributeDropdown.SelectedValue;
            }
            set {
                this.simBonusAttributeDropdown.SelectedValue = value;
            }
        }

        public string persuasionBonusAttribute {
            get {
                return this.persuasionBonusAttributeDropdown.SelectedValue;
            }
            set {
                this.persuasionBonusAttributeDropdown.SelectedValue = value;
            }
        }

        public string renownBonusAttribute {
            get {
                return this.renownBonusAttributeDropdown.SelectedValue;
            }
            set {
                this.renownBonusAttributeDropdown.SelectedValue = value;
            }
        }

        public string moraleBonusAttribute {
            get {
                return this.moraleBonusAttributeDropdown.SelectedValue;
            }
            set {
                this.moraleBonusAttributeDropdown.SelectedValue = value;
            }
        }

        public string partyMoraleBonusAttribute {
            get {
                return this.partyMoraleBonusAttributeDropdown.SelectedValue;
            }
            set {
                this.partyMoraleBonusAttributeDropdown.SelectedValue = value;
            }
        }

        public string wageBonusAttribute {
            get {
                return this.wageBonusAttributeDropdown.SelectedValue;
            }
            set {
                this.wageBonusAttributeDropdown.SelectedValue = value;
            }
        }

        public string partySizeBonusAttribute {
            get {
                return this.partySizeBonusAttributeDropdown.SelectedValue;
            }
            set {
                this.partySizeBonusAttributeDropdown.SelectedValue = value;
            }
        }


        public string incomeBonusAttribute {
            get {
                return this.incomeBonusAttributeDropdown.SelectedValue;
            }
            set {
                this.incomeBonusAttributeDropdown.SelectedValue = value;
            }
        }


        public string influenceBonusAttribute {
            get {
                return this.influenceBonusAttributeDropdown.SelectedValue;
            }
            set {
                this.influenceBonusAttributeDropdown.SelectedValue = value;
            }
        }

        public string xpBonusAttribute {
            get {
                return this.xpBonusAttributeDropdown.SelectedValue;
            }
            set {
                this.xpBonusAttributeDropdown.SelectedValue = value;
            }
        }





        public override string Id { get { return base.GetType().Assembly.GetName().Name; } }
        public override string DisplayName { get; } = "Better Attributes";
        public override string FolderName { get { return base.GetType().Assembly.GetName().Name; } }
        public override string FormatType { get; } = "xml";
        public bool LoadMCMConfigFile { get; set; } = true;
    }
}
