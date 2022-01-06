Public Class WarframeInformationPanel
    'Load Data
    Private Sub WarframeInformationPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        Select Case Form1.SendData.ToString
            Case "Ash"
                'Set the view image
                WarframePicBox.Image = My.Resources.Ash

                'Sort out Text Properties
                TextBox1.Text = "Ash is a fast, maneuverable Warframe that possesses a high degree of survivability in the field. Fleet movement complements deadly tools of assassination, making Ash a perfect balance between killing potency and stealth." + Environment.NewLine + Environment.NewLine + "Component blueprints drop from Manics. Manics have a 33.33% chance to drop a component blueprint, which has a 38.72% chance to be the Chassis, 38.72% to be the Neuroptics, and 22.56% to be the Systems. There is an expected 18-19 Manic kills to obtain each component at least once and 153±39 to be nearly guaranteed each component at least once."

                Me.Text = "Codex Entry - Ash"

                BlueprintBuildCreditCostLabel.Text = "25,000"
                NueropticCreditCostLabel.Text = "15,000"
                ChassiesCreditCostLabel.Text = "15,000"
                SystemsCreditCostLabel.Text = "15,000"
                BlueprintMarketCostLabel.Text = "35,000"
                NueropticsHours.Text = "12 Hours"
                ChassiesHours.Text = "12 Hours"
                SystemsHours.Text = "12 Hours"
                NueropticsRush.Text = "25"
                ChassiesRush.Text = "25"
                SystemsRush.Text = "25"
                WarframePlatinumCostLabel.Text = "375"
                PlatinumRushCost.Text = "50"

                BlueprintA.BackgroundImage = My.Resources.Nueroptics
                BPA.Text = "1"
                BlueprintB.BackgroundImage = My.Resources.Chassis
                BPB.Text = "1"
                BlueprintC.BackgroundImage = My.Resources.Systems
                BPC.Text = "1"
                BlueprintD.BackgroundImage = My.Resources.OrokinCell64
                BPD.Text = "1"

                NueropticsA.BackgroundImage = My.Resources.AlloyPlate64
                NueroA.Text = "150"
                NueropticsB.BackgroundImage = My.Resources.NeuralSensor64
                NueroB.Text = "1"
                NueropticsC.BackgroundImage = My.Resources.PolymerBundle64
                NueroC.Text = "150"
                NueropticsD.BackgroundImage = My.Resources.Rubedo64
                NueroD.Text = "500"

                ChassiesA.BackgroundImage = My.Resources.Morphics64
                ChassA.Text = "1"
                ChassiesB.BackgroundImage = My.Resources.Ferrite64
                ChassB.Text = "1000"
                ChassiesC.BackgroundImage = My.Resources.Rubedo64
                ChassC.Text = "300"
                ChassiesD.Visible = False
                ChassD.Visible = False

                SystemsA.BackgroundImage = My.Resources.ControlModule64
                SysA.Text = "1"
                SystemsB.BackgroundImage = My.Resources.Morphics64
                SysB.Text = "1"
                SystemsC.BackgroundImage = My.Resources.Salvage64
                SysC.Text = "500"
                SystemsD.BackgroundImage = My.Resources.Rubedo64
                SysD.Text = "500"
            Case "Ash Prime"
                'Set the view image
                WarframePicBox.Image = My.Resources.AshPrime

                'Sort out Text Properties
                TextBox1.Text = "Ash Prime is the Primed variant of Ash, possessing a higher shield capacity, armor and sprint speed, as well as an additional Naramon polarity. On May 24th, 2017, it was announced that Ash Prime would enter the Prime Vault and be retired from the reward tables on May 30th, 2017. Any preexisting components or fully-built frames will remain as is." + Environment.NewLine + Environment.NewLine + "As a prime Warframe, Ash Prime possesses a special passive ability where contact with an Orokin Void Death Orb will make them release an energy pulse that grants 250 Energy to all nearby allies. This effect can only occur once per Death Orb and can occur even if the Death Orb has been previously destroyed." + Environment.NewLine + Environment.NewLine + "Ash Prime has 85 more base Armor (150 compared to 65), 25 more base Shields (125 compared to 100 at Rank 0, 375 compared to 300 at Rank 30), and 0.05 more Sprint Speed (1.20 compared to 1.15) compared to the standard Ash."

                Me.Text = "Codex Entry - Ash Prime"

                BlueprintBuildCreditCostLabel.Text = "25,000"
                NueropticCreditCostLabel.Text = "15,000"
                ChassiesCreditCostLabel.Text = "15,000"
                SystemsCreditCostLabel.Text = "15,000"
                NueropticsHours.Text = "12 Hours"
                ChassiesHours.Text = "12 Hours"
                SystemsHours.Text = "12 Hours"
                NueropticsRush.Text = "25"
                ChassiesRush.Text = "25"
                SystemsRush.Text = "25"
                BlueprintMarketCostLabel.Text = "N/A"
                WarframePlatinumCostLabel.Text = "N/A"
                PlatinumRushCost.Text = "50"

                BlueprintA.BackgroundImage = My.Resources.PrimeNueroptics
                BPA.Text = "1"
                BlueprintB.BackgroundImage = My.Resources.PrimeChassis
                BPB.Text = "1"
                BlueprintC.BackgroundImage = My.Resources.PrimeSystems
                BPC.Text = "1"
                BlueprintD.BackgroundImage = My.Resources.OrokinCell64
                BPD.Text = "1"

                NueropticsA.BackgroundImage = My.Resources.AlloyPlate64
                NueroA.Text = "150"
                NueropticsB.BackgroundImage = My.Resources.NeuralSensor64
                NueroB.Text = "2"
                NueropticsC.BackgroundImage = My.Resources.PolymerBundle64
                NueroC.Text = "1000"
                NueropticsD.BackgroundImage = My.Resources.Rubedo64
                NueroD.Text = "750"

                ChassiesA.BackgroundImage = My.Resources.Gallium64
                ChassA.Text = "3"
                ChassiesB.BackgroundImage = My.Resources.NanoSpores64
                ChassB.Text = "1000"
                ChassiesC.BackgroundImage = My.Resources.Rubedo64
                ChassC.Text = "400"
                ChassiesD.Visible = False
                ChassD.Visible = False

                SystemsA.BackgroundImage = My.Resources.ControlModule64
                SysA.Text = "3"
                SystemsB.BackgroundImage = My.Resources.OrokinCell64
                SysB.Text = "1"
                SystemsC.BackgroundImage = My.Resources.Ferrite64
                SysC.Text = "1000"
                SystemsD.BackgroundImage = My.Resources.Circuits64
                SysD.Text = "500"
            Case "Atlas"
                'Set the view image
                WarframePicBox.Image = My.Resources.Atlas

                'Sort out Text Properties
                TextBox1.Text = "With stone cold fists and a titan's physique, Atlas bends rock to encrust and bulldoze through all challengers in his brawl. Champion of elemental earth, he manifests formidable ramparts, crushing boulders, and golem brethren to rampage his stomping grounds. Atlas was unearthed in Update 17.5." + Environment.NewLine + Environment.NewLine + "The blueprint is awarded after completing The Jordas Precept Quest, which unlocks the Jordas Golem Archwing Assassination mission that drops the remaining parts." + Environment.NewLine + "The drop chances for each component are 38.72%, 38.72%, 22.56% for Neuroptics, Chassis, Systems respectively as it is for most boss-rewarded Warframe components, with an expected 6-7 runs to obtain each component at least once and 39±10 runs to be nearly guaranteed each component at least once."

                Me.Text = "Codex Entry - Atlas"

                BlueprintBuildCreditCostLabel.Text = "30,000"
                NueropticCreditCostLabel.Text = "15,000"
                ChassiesCreditCostLabel.Text = "15,000"
                SystemsCreditCostLabel.Text = "15,000"
                NueropticsHours.Text = "12 Hours"
                ChassiesHours.Text = "12 Hours"
                SystemsHours.Text = "12 Hours"
                NueropticsRush.Text = "25"
                ChassiesRush.Text = "25"
                SystemsRush.Text = "25"
                BlueprintMarketCostLabel.Text = "N/A"
                WarframePlatinumCostLabel.Text = "275"
                PlatinumRushCost.Text = "50"

                BlueprintA.BackgroundImage = My.Resources.Nueroptics
                BPA.Text = "1"
                BlueprintB.BackgroundImage = My.Resources.Chassis
                BPB.Text = "1"
                BlueprintC.BackgroundImage = My.Resources.Systems
                BPC.Text = "1"
                BlueprintD.BackgroundImage = My.Resources.OrokinCell64
                BPD.Text = "1"

                NueropticsA.BackgroundImage = My.Resources.PolymerBundle64
                NueroA.Text = "1400"
                NueropticsB.BackgroundImage = My.Resources.AlloyPlate64
                NueroB.Text = "1100"
                NueropticsC.BackgroundImage = My.Resources.Circuits64
                NueroC.Text = "800"
                NueropticsD.BackgroundImage = My.Resources.Neurode64
                NueroD.Text = "5"

                ChassiesA.BackgroundImage = My.Resources.NanoSpores64
                ChassA.Text = "1800"
                ChassiesB.BackgroundImage = My.Resources.Cryotic
                ChassB.Text = "1300"
                ChassiesC.BackgroundImage = My.Resources.Rubedo64
                ChassC.Text = "400"
                ChassiesD.BackgroundImage = My.Resources.ArgonCrystal64
                ChassD.Text = "2"

                SystemsA.BackgroundImage = My.Resources.Ferrite64
                SysA.Text = "4600"
                SystemsB.BackgroundImage = My.Resources.PolymerBundle64
                SysB.Text = "1700"
                SystemsC.BackgroundImage = My.Resources.Morphics64
                SysC.Text = "5"
                SystemsD.BackgroundImage = My.Resources.OrokinCell64
                SysD.Text = "1"
            Case "Banshee"
                'Set the view image
                WarframePicBox.Image = My.Resources.Banshee

                'Sort out Text Properties
                TextBox1.Text = "Banshee is a sound-themed Warframe. Sophisticated acoustic powers enable Banshee to pinpoint enemy positions and weak spots, suppress gunfire sounds in her surrounding environment, and even emit trembling vibrations to topple her foes. Banshee debuted in Update 7." + Environment.NewLine + Environment.NewLine + "Banshee's blueprint can be purchased from the Tenno Lab interface in the Dojo once it has been researched. The blueprint is also required to research its components."

                Me.Text = "Codex Entry - Banshee"

                BlueprintBuildCreditCostLabel.Text = "25,000"
                NueropticCreditCostLabel.Text = "15,000"
                ChassiesCreditCostLabel.Text = "15,000"
                SystemsCreditCostLabel.Text = "15,000"
                NueropticsHours.Text = "12 Hours"
                ChassiesHours.Text = "12 Hours"
                SystemsHours.Text = "12 Hours"
                NueropticsRush.Text = "25"
                ChassiesRush.Text = "25"
                SystemsRush.Text = "25"
                BlueprintMarketCostLabel.Text = "N/A"
                WarframePlatinumCostLabel.Text = "275"
                PlatinumRushCost.Text = "50"

                BlueprintA.BackgroundImage = My.Resources.Nueroptics
                BPA.Text = "1"
                BlueprintB.BackgroundImage = My.Resources.Chassis
                BPB.Text = "1"
                BlueprintC.BackgroundImage = My.Resources.Systems
                BPC.Text = "1"
                BlueprintD.BackgroundImage = My.Resources.OrokinCell64
                BPD.Text = "1"

                NueropticsA.BackgroundImage = My.Resources.Circuits64
                NueroA.Text = "150"
                NueropticsB.BackgroundImage = My.Resources.NeuralSensor64
                NueroB.Text = "1"
                NueropticsC.BackgroundImage = My.Resources.PolymerBundle64
                NueroC.Text = "200"
                NueropticsD.BackgroundImage = My.Resources.Salvage64
                NueroD.Text = "500"

                ChassiesA.BackgroundImage = My.Resources.Morphics64
                ChassA.Text = "1"
                ChassiesB.BackgroundImage = My.Resources.Ferrite64
                ChassB.Text = "900"
                ChassiesC.BackgroundImage = My.Resources.Rubedo64
                ChassC.Text = "50"
                ChassiesD.Visible = False
                ChassD.Visible = False

                SystemsA.BackgroundImage = My.Resources.ControlModule64
                SysA.Text = "1"
                SystemsB.BackgroundImage = My.Resources.Circuits64
                SysB.Text = "1"
                SystemsC.BackgroundImage = My.Resources.Salvage64
                SysC.Text = "500"
                SystemsD.BackgroundImage = My.Resources.Plastids64
                SysD.Text = "400"
            Case "Banshee Prime"
                'Set the view image
                WarframePicBox.Image = My.Resources.BansheePrime

                'Sort out Text Properties
                TextBox1.Text = "Banshee Prime is the Primed variant of Banshee, possessing higher armor, sprint speed, and energy capacity, as well as an additional Naramon polarity." + Environment.NewLine + Environment.NewLine + "As a prime Warframe, Banshee Prime possesses a special passive ability where contact with an Orokin Void Death Orb will make them release an energy pulse that grants 250 Energy to all nearby allies. This effect can only occur once per Death Orb, and can occur even if the Death Orb has been previously destroyed."

                Me.Text = "Codex Entry - Banshee Prime"

                BlueprintBuildCreditCostLabel.Text = "25,000"
                NueropticCreditCostLabel.Text = "15,000"
                ChassiesCreditCostLabel.Text = "15,000"
                SystemsCreditCostLabel.Text = "15,000"
                NueropticsHours.Text = "12 Hours"
                ChassiesHours.Text = "12 Hours"
                SystemsHours.Text = "12 Hours"
                NueropticsRush.Text = "25"
                ChassiesRush.Text = "25"
                SystemsRush.Text = "25"
                BlueprintMarketCostLabel.Text = "N/A"
                WarframePlatinumCostLabel.Text = "275"
                PlatinumRushCost.Text = "50"

                BlueprintA.BackgroundImage = My.Resources.PrimeNueroptics
                BPA.Text = "1"
                BlueprintB.BackgroundImage = My.Resources.PrimeChassis
                BPB.Text = "1"
                BlueprintC.BackgroundImage = My.Resources.PrimeSystems
                BPC.Text = "1"
                BlueprintD.BackgroundImage = My.Resources.OrokinCell64
                BPD.Text = "5"

                NueropticsA.BackgroundImage = My.Resources.NeuralSensor64
                NueroA.Text = "2"
                NueropticsB.BackgroundImage = My.Resources.AlloyPlate64
                NueroB.Text = "6000"
                NueropticsC.BackgroundImage = My.Resources.Circuits64
                NueroC.Text = "1500"
                NueropticsD.BackgroundImage = My.Resources.NitainExtract64
                NueroD.Text = "2"

                ChassiesA.BackgroundImage = My.Resources.Morphics64
                ChassA.Text = "10"
                ChassiesB.BackgroundImage = My.Resources.Cryotic
                ChassB.Text = "1500"
                ChassiesC.BackgroundImage = My.Resources.Rubedo64
                ChassC.Text = "2000"
                ChassiesD.BackgroundImage = My.Resources.Salvage64
                ChassD.Text = "7000"

                SystemsA.BackgroundImage = My.Resources.ArgonCrystal64
                SysA.Text = "2"
                SystemsB.BackgroundImage = My.Resources.ControlModule64
                SysB.Text = "10"
                SystemsC.BackgroundImage = My.Resources.Oxium64
                SysC.Text = "300"
                SystemsD.BackgroundImage = My.Resources.Ferrite64
                SysD.Text = "4500"
            Case "Chroma"
                'Set the view image
                WarframePicBox.Image = My.Resources.Chroma

                'Sort out Text Properties
                TextBox1.Text = "The bestial avatar of the primal forces of nature, Chroma, confounds his foes and strengthens his allies with elemental caprice. Chroma awoke in Update 16." + Environment.NewLine + Environment.NewLine + "Chroma's main blueprint will be rewarded upon completion of the quest The New Strange." + Environment.NewLine + "Component blueprints are awarded by completing Junctions. The Neuroptics will be rewarded after completing the Uranus Junction, the Chassis the Neptune Junction and the Systems the Pluto Junction."

                Me.Text = "Codex Entry - Chroma"

                BlueprintBuildCreditCostLabel.Text = "25,000"
                NueropticCreditCostLabel.Text = "15,000"
                ChassiesCreditCostLabel.Text = "15,000"
                SystemsCreditCostLabel.Text = "15,000"
                NueropticsHours.Text = "12 Hours"
                ChassiesHours.Text = "12 Hours"
                SystemsHours.Text = "12 Hours"
                NueropticsRush.Text = "25"
                ChassiesRush.Text = "25"
                SystemsRush.Text = "25"
                BlueprintMarketCostLabel.Text = "N/A"
                WarframePlatinumCostLabel.Text = "375"
                PlatinumRushCost.Text = "50"

                BlueprintA.BackgroundImage = My.Resources.Nueroptics
                BPA.Text = "1"
                BlueprintB.BackgroundImage = My.Resources.Chassis
                BPB.Text = "1"
                BlueprintC.BackgroundImage = My.Resources.Systems
                BPC.Text = "1"
                BlueprintD.BackgroundImage = My.Resources.Nueroptics
                ToolTip1.SetToolTip(BlueprintD, "Volt Nueroptics")
                BPD.Text = "Volt Nueroptics"
                BPD.Left -= 25

                NueropticsA.BackgroundImage = My.Resources.Plastids64
                NueroA.Text = "200"
                NueropticsB.BackgroundImage = My.Resources.NeuralSensor64
                NueroB.Text = "2"
                NueropticsC.BackgroundImage = My.Resources.PolymerBundle64
                NueroC.Text = "350"
                NueropticsD.BackgroundImage = My.Resources.Nueroptics
                ToolTip1.SetToolTip(NueroD, "Ember Nueroptics")
                NueroD.Text = "Ember Nueroptics"
                NueroD.Left -= 35

                ChassiesA.BackgroundImage = My.Resources.Neurode64
                ChassA.Text = "2"
                ChassiesB.BackgroundImage = My.Resources.Salvage64
                ChassB.Text = "900"
                ChassiesC.BackgroundImage = My.Resources.Plastids64
                ChassC.Text = "50"
                ChassiesD.BackgroundImage = My.Resources.Chassis
                ToolTip1.SetToolTip(ChassD, "Frost Chassies")
                ChassD.Text = "Frost Chassies"
                ChassD.Left -= 25

                SystemsA.BackgroundImage = My.Resources.Oxium64
                SysA.Text = "400"
                SystemsB.BackgroundImage = My.Resources.ArgonCrystal64
                SysB.Text = "2"
                SystemsC.BackgroundImage = My.Resources.Neurode64
                SysC.Text = "1"
                SystemsD.BackgroundImage = My.Resources.Systems
                ToolTip1.SetToolTip(SysD, "Saryn Systems")
                SysD.Text = "Saryn Systems"
                SysD.Left -= 25
            Case "Ember"
                'Set the view image
                WarframePicBox.Image = My.Resources.Ember

                'Sort out Text Properties
                TextBox1.Text = "Ember is a fire-based Warframe that relies on almost purely offensive skills. Ember's fire abilities make her very effective against the Infested." + Environment.NewLine + Environment.NewLine + "Component blueprints drop from General Sargas Ruk (Tethys, Saturn)." + Environment.NewLine + "The drop chances for each component are 38.72%, 38.72%, 22.56% for Neuroptics, Chassis, Systems respectively as it is for most boss-rewarded Warframe components, with an expected 6-7 runs to obtain each component at least once and 39±10 runs to be nearly guaranteed each component at least once."

                Me.Text = "Codex Entry - Ember"

                BlueprintBuildCreditCostLabel.Text = "25,000"
                NueropticCreditCostLabel.Text = "15,000"
                ChassiesCreditCostLabel.Text = "15,000"
                SystemsCreditCostLabel.Text = "15,000"
                NueropticsHours.Text = "12 Hours"
                ChassiesHours.Text = "12 Hours"
                SystemsHours.Text = "12 Hours"
                NueropticsRush.Text = "25"
                ChassiesRush.Text = "25"
                SystemsRush.Text = "25"
                BlueprintMarketCostLabel.Text = "25,000"
                WarframePlatinumCostLabel.Text = "225"
                PlatinumRushCost.Text = "50"

                BlueprintA.BackgroundImage = My.Resources.Nueroptics
                BPA.Text = "1"
                BlueprintB.BackgroundImage = My.Resources.Chassis
                BPB.Text = "1"
                BlueprintC.BackgroundImage = My.Resources.Systems
                BPC.Text = "1"
                BlueprintD.BackgroundImage = My.Resources.OrokinCell64
                BPD.Text = "1"

                NueropticsA.BackgroundImage = My.Resources.AlloyPlate64
                NueroA.Text = "150"
                NueropticsB.BackgroundImage = My.Resources.NeuralSensor64
                NueroB.Text = "1"
                NueropticsC.BackgroundImage = My.Resources.PolymerBundle64
                NueroC.Text = "150"
                NueropticsD.BackgroundImage = My.Resources.Rubedo64
                NueroD.Text = "500"

                ChassiesA.BackgroundImage = My.Resources.Morphics64
                ChassA.Text = "1"
                ChassiesB.BackgroundImage = My.Resources.Ferrite64
                ChassB.Text = "1000"
                ChassiesC.BackgroundImage = My.Resources.Rubedo64
                ChassC.Text = "300"
                ChassiesD.Visible = False
                ChassD.Visible = False

                SystemsA.BackgroundImage = My.Resources.ControlModule64
                SysA.Text = "1"
                SystemsB.BackgroundImage = My.Resources.Morphics64
                SysB.Text = "1"
                SystemsC.BackgroundImage = My.Resources.Salvage64
                SysC.Text = "500"
                SystemsD.BackgroundImage = My.Resources.Plastids64
                SysD.Text = "220"
            Case "Ember Prime"
                'Set the view image
                WarframePicBox.Image = My.Resources.EmberPrime

                'Sort out Text Properties
                TextBox1.Text = "Ember Prime is the Primed variant of Ember, possessing higher shields and armor, as well as a Madurai Pol and Vazarin Pol polarity." + Environment.NewLine + "On September 29, 2015, it was announced that Ember Prime would enter the Prime Vault and be retired from the reward tables on October 6, 2015. Any preexisting components or fully-built frames will remain as is." + Environment.NewLine + "Ember Prime (along with Sicarus Prime, Glaive Prime, Frost Prime, Latron Prime, Reaper Prime, Loki Prime, Bo Prime, and Wyrm Prime) were available from Cetus Bounties from February 6, 2018 to April 10, 2018." + Environment.NewLine + "Ember Prime (along with Sicarus Prime, Glaive Prime, Frost Prime, Latron Prime, and Reaper Prime) were available from December 6th, 2016 to January 3rd, 2017 as part of the Fire and Ice Prime Vault." + Environment.NewLine + Environment.NewLine + "Ember Prime is the only primed frame to come with only 2 polarized slots instead of 3 unlike other Prime Warframes." + Environment.NewLine + "Possesses a Madurai and a Vazarin polarity, compared to Ember's double Naramon. Due to the entirely differing base polarities, builds on Ember may not transition as well to her Prime variant without sufficient use of Forma." + Environment.NewLine + "Ember Prime has an increased base armor and shield by 25 for a total of 125 compared to Ember's original 100 base armor and shield." + Environment.NewLine + "As a Prime Warframe, Ember Prime possesses a special passive ability where contact with an Orokin Void Death Orb will make them release an energy pulse that grants 250 Energy to all nearby allies. This effect can only occur once per Death Orb, and can occur even if the Death Orb has been previously destroyed."

                Me.Text = "Codex Entry - Ember Prime"

                BlueprintBuildCreditCostLabel.Text = "25,000"
                NueropticCreditCostLabel.Text = "15,000"
                ChassiesCreditCostLabel.Text = "15,000"
                SystemsCreditCostLabel.Text = "15,000"
                NueropticsHours.Text = "12 Hours"
                ChassiesHours.Text = "12 Hours"
                SystemsHours.Text = "12 Hours"
                NueropticsRush.Text = "25"
                ChassiesRush.Text = "25"
                SystemsRush.Text = "25"
                BlueprintMarketCostLabel.Text = "N/A"
                WarframePlatinumCostLabel.Text = "275"
                PlatinumRushCost.Text = "50"

                BlueprintA.BackgroundImage = My.Resources.PrimeNueroptics
                BPA.Text = "1"
                BlueprintB.BackgroundImage = My.Resources.PrimeChassis
                BPB.Text = "1"
                BlueprintC.BackgroundImage = My.Resources.PrimeSystems
                BPC.Text = "1"
                BlueprintD.BackgroundImage = My.Resources.OrokinCell64
                BPD.Text = "1"

                NueropticsA.BackgroundImage = My.Resources.AlloyPlate64
                NueroA.Text = "150"
                NueropticsB.BackgroundImage = My.Resources.NeuralSensor64
                NueroB.Text = "2"
                NueropticsC.BackgroundImage = My.Resources.PolymerBundle64
                NueroC.Text = "1000"
                NueropticsD.BackgroundImage = My.Resources.Rubedo64
                NueroD.Text = "750"

                ChassiesA.BackgroundImage = My.Resources.Morphics64
                ChassA.Text = "3"
                ChassiesB.BackgroundImage = My.Resources.Ferrite64
                ChassB.Text = "1000"
                ChassiesC.BackgroundImage = My.Resources.Rubedo64
                ChassC.Text = "300"
                ChassiesD.Visible = False
                ChassD.Visible = False

                SystemsA.BackgroundImage = My.Resources.ControlModule64
                SysA.Text = "1"
                SystemsB.BackgroundImage = My.Resources.Morphics64
                SysB.Text = "1"
                SystemsC.BackgroundImage = My.Resources.NanoSpores64
                SysC.Text = "1200"
                SystemsD.BackgroundImage = My.Resources.Plastids64
                SysD.Text = "700"
        End Select
    End Sub

    'Reset the information panel and the gloval variable
    Private Sub WarframeInformationPanel_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form1.SendData = Nothing
        Me.Dispose()
    End Sub

    Private Sub FlowLayoutPanel17_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel17.Paint

    End Sub
End Class