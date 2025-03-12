namespace BalatroJokerSearch
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.jokerImageList = new System.Windows.Forms.ImageList(this.components);
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.jokerListView = new System.Windows.Forms.ListView();
            this.detailGroupBox = new System.Windows.Forms.GroupBox();
            this.jokerAbilityLabel = new System.Windows.Forms.Label();
            this.jokerRarityLabel = new System.Windows.Forms.Label();
            this.jokerCostLabel = new System.Windows.Forms.Label();
            this.jokerDescriptionLabel = new System.Windows.Forms.Label();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.abilityComboBox = new System.Windows.Forms.ComboBox();
            this.abilityLabel = new System.Windows.Forms.Label();
            this.rarityComboBox = new System.Windows.Forms.ComboBox();
            this.rarityLabel = new System.Windows.Forms.Label();
            this.costToComboBox = new System.Windows.Forms.ComboBox();
            this.costToLabel = new System.Windows.Forms.Label();
            this.costFromComboBox = new System.Windows.Forms.ComboBox();
            this.costFromLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.resultsGroupBox.SuspendLayout();
            this.detailGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // jokerImageList
            // 
            this.jokerImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("jokerImageList.ImageStream")));
            this.jokerImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.jokerImageList.Images.SetKeyName(0, "8_Ball.png");
            this.jokerImageList.Images.SetKeyName(1, "Abstract_Joker.png");
            this.jokerImageList.Images.SetKeyName(2, "Acrobat.png");
            this.jokerImageList.Images.SetKeyName(3, "Ancient_Joker.png");
            this.jokerImageList.Images.SetKeyName(4, "Arrowhead.png");
            this.jokerImageList.Images.SetKeyName(5, "Astronomer.png");
            this.jokerImageList.Images.SetKeyName(6, "Banner.png");
            this.jokerImageList.Images.SetKeyName(7, "Baron.png");
            this.jokerImageList.Images.SetKeyName(8, "Baseball_Card.png");
            this.jokerImageList.Images.SetKeyName(9, "Blackboard.png");
            this.jokerImageList.Images.SetKeyName(10, "Bloodstone.png");
            this.jokerImageList.Images.SetKeyName(11, "Blue_Joker.png");
            this.jokerImageList.Images.SetKeyName(12, "Blueprint.png");
            this.jokerImageList.Images.SetKeyName(13, "Bootstraps.png");
            this.jokerImageList.Images.SetKeyName(14, "Brainstorm.png");
            this.jokerImageList.Images.SetKeyName(15, "Bull.png");
            this.jokerImageList.Images.SetKeyName(16, "Burglar.png");
            this.jokerImageList.Images.SetKeyName(17, "Burnt_Joker.png");
            this.jokerImageList.Images.SetKeyName(18, "Business_Card.png");
            this.jokerImageList.Images.SetKeyName(19, "Caino.png");
            this.jokerImageList.Images.SetKeyName(20, "Campfire.png");
            this.jokerImageList.Images.SetKeyName(21, "Card_Sharp.png");
            this.jokerImageList.Images.SetKeyName(22, "Cartomancer.png");
            this.jokerImageList.Images.SetKeyName(23, "Castle.png");
            this.jokerImageList.Images.SetKeyName(24, "Cavendish.png");
            this.jokerImageList.Images.SetKeyName(25, "Ceremonial_Dagger.png");
            this.jokerImageList.Images.SetKeyName(26, "Certificate.png");
            this.jokerImageList.Images.SetKeyName(27, "Chaos_the_Clown.png");
            this.jokerImageList.Images.SetKeyName(28, "Chicot.png");
            this.jokerImageList.Images.SetKeyName(29, "Clever_Joker.png");
            this.jokerImageList.Images.SetKeyName(30, "Cloud_9.png");
            this.jokerImageList.Images.SetKeyName(31, "Constellation.png");
            this.jokerImageList.Images.SetKeyName(32, "Crafty_Joker.png");
            this.jokerImageList.Images.SetKeyName(33, "Crazy_Joker.png");
            this.jokerImageList.Images.SetKeyName(34, "Credit_Card.png");
            this.jokerImageList.Images.SetKeyName(35, "DNA.png");
            this.jokerImageList.Images.SetKeyName(36, "Delayed_Gratification.png");
            this.jokerImageList.Images.SetKeyName(37, "Devious_Joker.png");
            this.jokerImageList.Images.SetKeyName(38, "Diet_Cola.png");
            this.jokerImageList.Images.SetKeyName(39, "Driver\'s_License.png");
            this.jokerImageList.Images.SetKeyName(40, "Droll_Joker.png");
            this.jokerImageList.Images.SetKeyName(41, "Drunkard.png");
            this.jokerImageList.Images.SetKeyName(42, "Dusk.png");
            this.jokerImageList.Images.SetKeyName(43, "Egg.png");
            this.jokerImageList.Images.SetKeyName(44, "Erosion.png");
            this.jokerImageList.Images.SetKeyName(45, "Even_Steven.png");
            this.jokerImageList.Images.SetKeyName(46, "Faceless_Joker.png");
            this.jokerImageList.Images.SetKeyName(47, "Fibonacci.png");
            this.jokerImageList.Images.SetKeyName(48, "Flash_Card.png");
            this.jokerImageList.Images.SetKeyName(49, "Flower_Pot.png");
            this.jokerImageList.Images.SetKeyName(50, "Fortune_Teller.png");
            this.jokerImageList.Images.SetKeyName(51, "Four_Fingers.png");
            this.jokerImageList.Images.SetKeyName(52, "Gift_Card.png");
            this.jokerImageList.Images.SetKeyName(53, "Glass_Joker.png");
            this.jokerImageList.Images.SetKeyName(54, "Gluttonous_Joker.png");
            this.jokerImageList.Images.SetKeyName(55, "Golden_Joker.png");
            this.jokerImageList.Images.SetKeyName(56, "Golden_Ticket.png");
            this.jokerImageList.Images.SetKeyName(57, "Greedy_Joker.png");
            this.jokerImageList.Images.SetKeyName(58, "Green_Joker.png");
            this.jokerImageList.Images.SetKeyName(59, "Gros_Michel.png");
            this.jokerImageList.Images.SetKeyName(60, "Hack.png");
            this.jokerImageList.Images.SetKeyName(61, "Half_Joker.png");
            this.jokerImageList.Images.SetKeyName(62, "Hallucination.png");
            this.jokerImageList.Images.SetKeyName(63, "Hanging_Chad.png");
            this.jokerImageList.Images.SetKeyName(64, "Hiker.png");
            this.jokerImageList.Images.SetKeyName(65, "Hit_the_Road.png");
            this.jokerImageList.Images.SetKeyName(66, "Hologram.png");
            this.jokerImageList.Images.SetKeyName(67, "Ice_Cream.png");
            this.jokerImageList.Images.SetKeyName(68, "Invisible_Joker.png");
            this.jokerImageList.Images.SetKeyName(69, "Joker.png");
            this.jokerImageList.Images.SetKeyName(70, "Joker_Stencil.png");
            this.jokerImageList.Images.SetKeyName(71, "Jolly_Joker.png");
            this.jokerImageList.Images.SetKeyName(72, "Juggler.png");
            this.jokerImageList.Images.SetKeyName(73, "Loyalty_Card.png");
            this.jokerImageList.Images.SetKeyName(74, "Luchador.png");
            this.jokerImageList.Images.SetKeyName(75, "Lucky_Cat.png");
            this.jokerImageList.Images.SetKeyName(76, "Lusty_Joker.png");
            this.jokerImageList.Images.SetKeyName(77, "Mad_Joker.png");
            this.jokerImageList.Images.SetKeyName(78, "Madness.png");
            this.jokerImageList.Images.SetKeyName(79, "Mail-In_Rebate.png");
            this.jokerImageList.Images.SetKeyName(80, "Marble_Joker.png");
            this.jokerImageList.Images.SetKeyName(81, "Matador.png");
            this.jokerImageList.Images.SetKeyName(82, "Merry_Andy.png");
            this.jokerImageList.Images.SetKeyName(83, "Midas_Mask.png");
            this.jokerImageList.Images.SetKeyName(84, "Mime.png");
            this.jokerImageList.Images.SetKeyName(85, "Misprint.png");
            this.jokerImageList.Images.SetKeyName(86, "Mr._Bones.png");
            this.jokerImageList.Images.SetKeyName(87, "Mystic_Summit.png");
            this.jokerImageList.Images.SetKeyName(88, "Obelisk.png");
            this.jokerImageList.Images.SetKeyName(89, "Odd_Todd.png");
            this.jokerImageList.Images.SetKeyName(90, "Onyx_Agate.png");
            this.jokerImageList.Images.SetKeyName(91, "Oops!_All_6s.png");
            this.jokerImageList.Images.SetKeyName(92, "Pareidolia.png");
            this.jokerImageList.Images.SetKeyName(93, "Perkeo.png");
            this.jokerImageList.Images.SetKeyName(94, "Photograph.png");
            this.jokerImageList.Images.SetKeyName(95, "Popcorn.png");
            this.jokerImageList.Images.SetKeyName(96, "Raised_Fist.png");
            this.jokerImageList.Images.SetKeyName(97, "Ramen.png");
            this.jokerImageList.Images.SetKeyName(98, "Red_Card.png");
            this.jokerImageList.Images.SetKeyName(99, "Reserved_Parking.png");
            this.jokerImageList.Images.SetKeyName(100, "Ride_the_Bus.png");
            this.jokerImageList.Images.SetKeyName(101, "Riff-Raff.png");
            this.jokerImageList.Images.SetKeyName(102, "Rocket.png");
            this.jokerImageList.Images.SetKeyName(103, "Rough_Gem.png");
            this.jokerImageList.Images.SetKeyName(104, "Runner.png");
            this.jokerImageList.Images.SetKeyName(105, "Satellite.png");
            this.jokerImageList.Images.SetKeyName(106, "Scary_Face.png");
            this.jokerImageList.Images.SetKeyName(107, "Scholar.png");
            this.jokerImageList.Images.SetKeyName(108, "Seance.png");
            this.jokerImageList.Images.SetKeyName(109, "Seeing_Double.png");
            this.jokerImageList.Images.SetKeyName(110, "Seltzer.png");
            this.jokerImageList.Images.SetKeyName(111, "Shoot_the_Moon.png");
            this.jokerImageList.Images.SetKeyName(112, "Shortcut.png");
            this.jokerImageList.Images.SetKeyName(113, "Showman.png");
            this.jokerImageList.Images.SetKeyName(114, "Sixth_Sense.png");
            this.jokerImageList.Images.SetKeyName(115, "Sly_Joker.png");
            this.jokerImageList.Images.SetKeyName(116, "Smeared_Joker.png");
            this.jokerImageList.Images.SetKeyName(117, "Smiley_Face.png");
            this.jokerImageList.Images.SetKeyName(118, "Sock_and_Buskin.png");
            this.jokerImageList.Images.SetKeyName(119, "Space_Joker.png");
            this.jokerImageList.Images.SetKeyName(120, "Spare_Trousers.png");
            this.jokerImageList.Images.SetKeyName(121, "Splash.png");
            this.jokerImageList.Images.SetKeyName(122, "Square_Joker.png");
            this.jokerImageList.Images.SetKeyName(123, "Steel_Joker.png");
            this.jokerImageList.Images.SetKeyName(124, "Stone_Joker.png");
            this.jokerImageList.Images.SetKeyName(125, "Stuntman.png");
            this.jokerImageList.Images.SetKeyName(126, "Supernova.png");
            this.jokerImageList.Images.SetKeyName(127, "Superposition.png");
            this.jokerImageList.Images.SetKeyName(128, "Swashbuckler.png");
            this.jokerImageList.Images.SetKeyName(129, "The_Duo.png");
            this.jokerImageList.Images.SetKeyName(130, "The_Family.png");
            this.jokerImageList.Images.SetKeyName(131, "The_Idol.png");
            this.jokerImageList.Images.SetKeyName(132, "The_Order.png");
            this.jokerImageList.Images.SetKeyName(133, "The_Tribe.png");
            this.jokerImageList.Images.SetKeyName(134, "The_Trio.png");
            this.jokerImageList.Images.SetKeyName(135, "Throwback.png");
            this.jokerImageList.Images.SetKeyName(136, "To_Do_List.png");
            this.jokerImageList.Images.SetKeyName(137, "To_the_Moon.png");
            this.jokerImageList.Images.SetKeyName(138, "Trading_Card.png");
            this.jokerImageList.Images.SetKeyName(139, "Triboulet.png");
            this.jokerImageList.Images.SetKeyName(140, "Troubadour.png");
            this.jokerImageList.Images.SetKeyName(141, "Turtle_Bean.png");
            this.jokerImageList.Images.SetKeyName(142, "Vagabond.png");
            this.jokerImageList.Images.SetKeyName(143, "Vampire.png");
            this.jokerImageList.Images.SetKeyName(144, "Walkie_Talkie.png");
            this.jokerImageList.Images.SetKeyName(145, "Wee_Joker.png");
            this.jokerImageList.Images.SetKeyName(146, "Wily_Joker.png");
            this.jokerImageList.Images.SetKeyName(147, "Wrathful_Joker.png");
            this.jokerImageList.Images.SetKeyName(148, "Yorick.png");
            this.jokerImageList.Images.SetKeyName(149, "Zany_Joker.png");
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.jokerListView);
            this.resultsGroupBox.Location = new System.Drawing.Point(208, 13);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(327, 402);
            this.resultsGroupBox.TabIndex = 1;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results";
            // 
            // jokerListView
            // 
            this.jokerListView.BackColor = System.Drawing.SystemColors.Window;
            this.jokerListView.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jokerListView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.jokerListView.HideSelection = false;
            this.jokerListView.Location = new System.Drawing.Point(7, 19);
            this.jokerListView.Name = "jokerListView";
            this.jokerListView.Size = new System.Drawing.Size(315, 377);
            this.jokerListView.SmallImageList = this.jokerImageList;
            this.jokerListView.TabIndex = 1;
            this.jokerListView.UseCompatibleStateImageBehavior = false;
            this.jokerListView.View = System.Windows.Forms.View.SmallIcon;
            this.jokerListView.SelectedIndexChanged += new System.EventHandler(this.jokerListView_SelectedIndexChanged);
            // 
            // detailGroupBox
            // 
            this.detailGroupBox.Controls.Add(this.jokerAbilityLabel);
            this.detailGroupBox.Controls.Add(this.jokerRarityLabel);
            this.detailGroupBox.Controls.Add(this.jokerCostLabel);
            this.detailGroupBox.Controls.Add(this.jokerDescriptionLabel);
            this.detailGroupBox.Location = new System.Drawing.Point(13, 233);
            this.detailGroupBox.Name = "detailGroupBox";
            this.detailGroupBox.Size = new System.Drawing.Size(188, 182);
            this.detailGroupBox.TabIndex = 2;
            this.detailGroupBox.TabStop = false;
            this.detailGroupBox.Text = "Details";
            // 
            // jokerAbilityLabel
            // 
            this.jokerAbilityLabel.AutoSize = true;
            this.jokerAbilityLabel.Location = new System.Drawing.Point(16, 70);
            this.jokerAbilityLabel.Name = "jokerAbilityLabel";
            this.jokerAbilityLabel.Size = new System.Drawing.Size(0, 13);
            this.jokerAbilityLabel.TabIndex = 4;
            // 
            // jokerRarityLabel
            // 
            this.jokerRarityLabel.AutoSize = true;
            this.jokerRarityLabel.Location = new System.Drawing.Point(16, 48);
            this.jokerRarityLabel.Name = "jokerRarityLabel";
            this.jokerRarityLabel.Size = new System.Drawing.Size(0, 13);
            this.jokerRarityLabel.TabIndex = 3;
            // 
            // jokerCostLabel
            // 
            this.jokerCostLabel.AutoSize = true;
            this.jokerCostLabel.Location = new System.Drawing.Point(16, 25);
            this.jokerCostLabel.Name = "jokerCostLabel";
            this.jokerCostLabel.Size = new System.Drawing.Size(0, 13);
            this.jokerCostLabel.TabIndex = 2;
            // 
            // jokerDescriptionLabel
            // 
            this.jokerDescriptionLabel.AutoSize = true;
            this.jokerDescriptionLabel.Location = new System.Drawing.Point(15, 93);
            this.jokerDescriptionLabel.Name = "jokerDescriptionLabel";
            this.jokerDescriptionLabel.Size = new System.Drawing.Size(0, 13);
            this.jokerDescriptionLabel.TabIndex = 1;
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.clearButton);
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.abilityComboBox);
            this.searchGroupBox.Controls.Add(this.abilityLabel);
            this.searchGroupBox.Controls.Add(this.rarityComboBox);
            this.searchGroupBox.Controls.Add(this.rarityLabel);
            this.searchGroupBox.Controls.Add(this.costToComboBox);
            this.searchGroupBox.Controls.Add(this.costToLabel);
            this.searchGroupBox.Controls.Add(this.costFromComboBox);
            this.searchGroupBox.Controls.Add(this.costFromLabel);
            this.searchGroupBox.Controls.Add(this.costLabel);
            this.searchGroupBox.Controls.Add(this.nameTextBox);
            this.searchGroupBox.Controls.Add(this.nameLabel);
            this.searchGroupBox.Location = new System.Drawing.Point(13, 13);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(188, 214);
            this.searchGroupBox.TabIndex = 0;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(19, 185);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(100, 185);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // abilityComboBox
            // 
            this.abilityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.abilityComboBox.FormattingEnabled = true;
            this.abilityComboBox.Items.AddRange(new object[] {
            "",
            "+ Mult",
            "+ Chips",
            "+ Mult + Chips",
            "X Mult",
            "Economy",
            "Retrigger/Copy",
            "Other"});
            this.abilityComboBox.Location = new System.Drawing.Point(43, 151);
            this.abilityComboBox.Name = "abilityComboBox";
            this.abilityComboBox.Size = new System.Drawing.Size(100, 21);
            this.abilityComboBox.TabIndex = 10;
            // 
            // abilityLabel
            // 
            this.abilityLabel.AutoSize = true;
            this.abilityLabel.Location = new System.Drawing.Point(77, 135);
            this.abilityLabel.Name = "abilityLabel";
            this.abilityLabel.Size = new System.Drawing.Size(37, 13);
            this.abilityLabel.TabIndex = 9;
            this.abilityLabel.Text = "Ability:";
            // 
            // rarityComboBox
            // 
            this.rarityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rarityComboBox.FormattingEnabled = true;
            this.rarityComboBox.Items.AddRange(new object[] {
            "",
            "Common",
            "Uncommon",
            "Rare",
            "Legendary"});
            this.rarityComboBox.Location = new System.Drawing.Point(43, 111);
            this.rarityComboBox.Name = "rarityComboBox";
            this.rarityComboBox.Size = new System.Drawing.Size(100, 21);
            this.rarityComboBox.TabIndex = 8;
            // 
            // rarityLabel
            // 
            this.rarityLabel.AutoSize = true;
            this.rarityLabel.Location = new System.Drawing.Point(77, 95);
            this.rarityLabel.Name = "rarityLabel";
            this.rarityLabel.Size = new System.Drawing.Size(37, 13);
            this.rarityLabel.TabIndex = 7;
            this.rarityLabel.Text = "Rarity:";
            // 
            // costToComboBox
            // 
            this.costToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.costToComboBox.FormattingEnabled = true;
            this.costToComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "20"});
            this.costToComboBox.Location = new System.Drawing.Point(123, 71);
            this.costToComboBox.Name = "costToComboBox";
            this.costToComboBox.Size = new System.Drawing.Size(52, 21);
            this.costToComboBox.TabIndex = 6;
            // 
            // costToLabel
            // 
            this.costToLabel.AutoSize = true;
            this.costToLabel.Location = new System.Drawing.Point(101, 74);
            this.costToLabel.Name = "costToLabel";
            this.costToLabel.Size = new System.Drawing.Size(16, 13);
            this.costToLabel.TabIndex = 5;
            this.costToLabel.Text = "to";
            // 
            // costFromComboBox
            // 
            this.costFromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.costFromComboBox.FormattingEnabled = true;
            this.costFromComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "20"});
            this.costFromComboBox.Location = new System.Drawing.Point(43, 71);
            this.costFromComboBox.Name = "costFromComboBox";
            this.costFromComboBox.Size = new System.Drawing.Size(52, 21);
            this.costFromComboBox.TabIndex = 4;
            // 
            // costFromLabel
            // 
            this.costFromLabel.AutoSize = true;
            this.costFromLabel.Location = new System.Drawing.Point(7, 74);
            this.costFromLabel.Name = "costFromLabel";
            this.costFromLabel.Size = new System.Drawing.Size(30, 13);
            this.costFromLabel.TabIndex = 3;
            this.costFromLabel.Text = "From";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(80, 55);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(31, 13);
            this.costLabel.TabIndex = 2;
            this.costLabel.Text = "Cost:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(43, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(76, 16);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 421);
            this.Controls.Add(this.detailGroupBox);
            this.Controls.Add(this.resultsGroupBox);
            this.Controls.Add(this.searchGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Balatro Joker Selector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.resultsGroupBox.ResumeLayout(false);
            this.detailGroupBox.ResumeLayout(false);
            this.detailGroupBox.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList jokerImageList;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.ListView jokerListView;
        private System.Windows.Forms.GroupBox detailGroupBox;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Label costFromLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox rarityComboBox;
        private System.Windows.Forms.Label rarityLabel;
        private System.Windows.Forms.ComboBox costToComboBox;
        private System.Windows.Forms.Label costToLabel;
        private System.Windows.Forms.ComboBox costFromComboBox;
        private System.Windows.Forms.ComboBox abilityComboBox;
        private System.Windows.Forms.Label abilityLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label jokerRarityLabel;
        private System.Windows.Forms.Label jokerCostLabel;
        private System.Windows.Forms.Label jokerDescriptionLabel;
        private System.Windows.Forms.Label jokerAbilityLabel;
        private System.Windows.Forms.Button clearButton;
    }
}

