-- Create Baltro Joker Searcher database
CREATE DATABASE BalatroJokerSearch;
GO

-- Use Balatro Joker Search database
USE BalatroJokerSearch;
GO

-- Create Jokers table
CREATE TABLE Jokers (
	JokerID	INT	PRIMARY KEY,
	Name	NVARCHAR(30),
	Description	NVARCHAR(150),
	Cost	INT,
	Rarity	NVARCHAR(20),
	Ability	NVARCHAR(20)
);
GO

-- Create search procedure
CREATE PROC spSearchJokers
	@NameContains	NVARCHAR(30),
	@CostMin	INT,
	@CostMax	INT,
	@Rarity	NVARCHAR(20),
	@Ability	NVARCHAR(20)
AS
BEGIN
	SELECT *
	FROM Jokers
	WHERE
		Name LIKE '%' + @NameContains + '%' AND
		Cost >= @CostMin AND
		Cost <= @CostMax AND
		Rarity LIKE @Rarity + '%' AND
		Ability LIKE '%' + @Ability AND
		Ability LIKE @Ability + '%'
END;
GO

-- Create get joker by ID procedure
CREATE PROC spGetJokerByID
	@JokerID	INT
AS
BEGIN
	SELECT *
	FROM Jokers
	WHERE @JokerID = JokerID
END
GO

-- Insert all joker values
INSERT INTO Jokers (
	JokerID,
	Name,
	Description,
	Cost,
	Rarity,
	Ability
) VALUES
	(0, '8 Ball', '1 in 4 chance for each played 8 to create a Tarot card when scored (Must have room)', 5, 'Common', 'Other'),
	(1, 'Abstract Joker', '+3 Mult for each Joker card', 4, 'Common', '+ Mult'),
	(2, 'Acrobat', 'X3 Mult on final hand of round', 6, 'Uncommon', 'X Mult'),
	(3, 'Ancient Joker', 'Each played card with [suit] gives X1.5 Mult when scored, suit changes at end of round', 8, 'Rare', 'X Mult'),
	(4, 'Arrowhead', 'Played cards with  Spade suit give +50 Chips when scored', 7, 'Uncommon', '+ Chips'),
	(5, 'Astronomer', 'All Planet cards and Celestial Packs in the shop are free', 8, 'Uncommon', 'Other'),
	(6, 'Banner', '+30 Chips for each remaining discard', 5, 'Common', '+ Chips'),
	(7, 'Baron', 'Each King held in hand gives X1.5 Mult', 8, 'Rare', 'X Mult'),
	(8, 'Baseball Card', 'Uncommon Jokers each give X1.5 Mult', 8, 'Rare', 'X Mult'),
	(9, 'Blackboard', 'X3 Mult if all cards held in hand are  Spades or  Clubs', 6, 'Uncommon', 'X Mult'),
	(10, 'Bloodstone', '1 in 2 chance for played cards with  Heart suit to give X1.5 Mult when scored', 7, 'Uncommon', 'X Mult'),
	(11, 'Blue Joker', '+2 Chips for each remaining card in deck', 5, 'Common', '+ Chips'),
	(12, 'Blueprint', 'Copies ability of Joker to the right', 10, 'Rare', 'Retrigger/Copy'),
	(13, 'Bootstraps', '+2 Mult for every $5 you have', 7, 'Uncommon', '+ Mult'),
	(14, 'Brainstorm', 'Copies the ability of leftmost Joker', 10, 'Rare', 'Retrigger/Copy'),
	(15, 'Bull', '+2 Chips for each $1 you have', 6, 'Uncommon', '+ Chips'),
	(16, 'Burglar', 'When Blind is selected, gain +3 Hands and lose all discards', 6, 'Uncommon', 'Other'),
	(17, 'Burnt Joker', 'Upgrade the level of the first discarded poker hand each round', 8, 'Rare', 'Other'),
	(18, 'Business Card', 'Played face cards have a 1 in 2 chance to give $2 when scored', 4, 'Common', 'Economy'),
	(19, 'Caino', 'This Joker gains X1 Mult when a face card is destroyed', 20, 'Legendary', 'X Mult'),
	(20, 'Campfire', 'This Joker gains X0.25 Mult for each card sold, resets when Boss Blind is defeated', 9, 'Rare', 'X Mult'),
	(21, 'Card Sharp', 'X3 Mult if played poker hand has already been played this round', 6, 'Uncommon', 'X Mult'),
	(22, 'Cartomancer', 'Create a Tarot card when Blind is selected (Must have room)', 6, 'Uncommon', 'Other'),
	(23, 'Castle', 'This Joker gains +3 Chips per discarded [suit] card, suit changes every round', 6, 'Uncommon', '+ Chips'),
	(24, 'Cavendish', 'X3 Mult 1 in 1000 chance this card is destroyed at the end of round', 4, 'Common', 'X Mult'),
	(25, 'Ceremonial Dagger', 'When Blind is selected, destroy Joker to the right and permanently add double its sell value to this Mult (Currently +0 Mult)', 6, 'Uncommon', '+ Mult'),
	(26, 'Certificate', 'When round begins, add a random playing card with a random seal to your hand', 6, 'Uncommon', 'Other'),
	(27, 'Chaos the Clown', '1 free Reroll per shop', 4, 'Common', 'Other'),
	(28, 'Chicot', 'Disables effect of every Boss Blind', 20, 'Legendary', 'Other'),
	(29, 'Clever Joker', '+80 Chips if played hand contains a Two Pair', 4, 'Common', '+ Chips'),
	(30, 'Cloud 9', 'Earn $1 for each 9 in your full deck at end of round', 7, 'Uncommon', 'Economy'),
	(31, 'Constellation', 'This Joker gains X0.1 Mult every time a Planet card is used', 6, 'Uncommon', 'X Mult'),
	(32, 'Crafty Joker', '+80 Chips if played hand contains a Flush', 4, 'Common', '+ Chips'),
	(33, 'Crazy Joker', '+12 Mult if played hand contains a Straight', 4, 'Common', '+ Mult'),
	(34, 'Credit Card', 'Go up to -$20 in debt', 1, 'Common', 'Economy'),
	(35, 'DNA', 'If first hand of round has only 1 card, add a permanent copy to deck and draw it to hand', 8, 'Rare', 'Other'),
	(36, 'Delayed Gratification', 'Earn $2 per discard if no discards are used by end of the round', 4, 'Common', 'Economy'),
	(37, 'Devious Joker', '+100 Chips if played hand contains a Straight', 4, 'Common', '+ Chips'),
	(38, 'Diet Cola', 'Sell this card to create a free Double Tag', 6, 'Uncommon', 'Other'),
	(39, 'Driver''s License', 'X3 Mult if you have at least 16 Enhanced cards in your full deck', 7, 'Rare', 'X Mult'),
	(40, 'Droll Joker', '+10 Mult if played hand contains a Flush', 4, 'Common', '+ Mult'),
	(41, 'Drunkard', '+1 discard each round', 4, 'Common', 'Other'),
	(42, 'Dusk', 'Retrigger all played cards in final hand of the round', 5, 'Uncommon', 'Retrigger/Copy'),
	(43, 'Egg', 'Gains $3 of sell value at end of round', 4, 'Common', 'Economy'),
	(44, 'Erosion', '+4 Mult for each card below [the deck''s starting size] in your full deck', 6, 'Uncommon', '+ Mult'),
	(45, 'Even Steven', 'Played cards with even rank give +4 Mult when scored (10, 8, 6, 4, 2)', 4, 'Common', '+ Mult'),
	(46, 'Faceless Joker', 'Earn $5 if 3 or more face cards are discarded at the same time', 4, 'Common', 'Economy'),
	(47, 'Fibonacci', 'Each played Ace, 2, 3, 5, or 8 gives +8 Mult when scored', 8, 'Uncommon', '+ Mult'),
	(48, 'Flash Card', 'This Joker gains +2 Mult per reroll in the shop', 5, 'Uncommon', '+ Mult'),
	(49, 'Flower Pot', 'X3 Mult if poker hand contains a  Diamond card,  Club card,  Heart card, and  Spade card', 6, 'Uncommon', 'X Mult'),
	(50, 'Fortune Teller', '+1 Mult per Tarot card used this run', 6, 'Common', '+ Mult'),
	(51, 'Four Fingers', 'All Flushes and Straights can be made with 4 cards', 7, 'Uncommon', 'Other'),
	(52, 'Gift Card', 'Add $1 of sell value to every Joker and Consumable card at end of round', 6, 'Uncommon', 'Economy'),
	(53, 'Glass Joker', 'This Joker gains X0.75 Mult for every Glass Card that is destroyed', 6, 'Uncommon', 'X Mult'),
	(54, 'Gluttonous Joker', 'Played cards with  Club suit give +3 Mult when scored', 5, 'Common', '+ Mult'),
	(55, 'Golden Joker', 'Earn $4 at end of round', 6, 'Common', 'Economy'),
	(56, 'Golden Ticket', 'Played Gold cards earn $4 when scored', 5, 'Common', 'Economy'),
	(57, 'Greedy Joker', 'Played cards with  Diamond suit give +3 Mult when scored', 5, 'Common', '+ Mult'),
	(58, 'Green Joker', '+1 Mult per hand played -1 Mult per discard', 4, 'Common', '+ Mult'),
	(59, 'Gros Michel', '+15 Mult 1 in 6 chance this is destroyed at the end of round.', 5, 'Common', '+ Mult'),
	(60, 'Hack', 'Retrigger each played 2, 3, 4, or 5', 6, 'Uncommon', 'Retrigger/Copy'),
	(61, 'Half Joker', '+20 Mult if played hand contains 3 or fewer cards', 5, 'Common', '+ Mult'),
	(62, 'Hallucination', '1 in 2 chance to create a Tarot card when any Booster Pack is opened (Must have room)', 4, 'Common', 'Other'),
	(63, 'Hanging Chad', 'Retrigger first played card used in scoring 2 additional times', 4, 'Common', 'Retrigger/Copy'),
	(64, 'Hiker', 'Every played card permanently gains +5 Chips when scored', 5, 'Uncommon', '+ Chips'),
	(65, 'Hit the Road', 'This Joker gains X0.5 Mult for every Jack discarded this round', 8, 'Rare', 'X Mult'),
	(66, 'Hologram', 'This Joker gains X0.25 Mult every time a playing card is added to your deck (Currently X1 Mult)', 7, 'Uncommon', 'X Mult'),
	(67, 'Ice Cream', '+100 Chips -5 Chips for every hand played', 5, 'Common', '+ Chips'),
	(68, 'Invisible Joker', 'After 2 rounds, sell this card to Duplicate a random Joker', 8, 'Rare', 'Other'),
	(69, 'Joker', '+4 Mult', 2, 'Common', '+ Mult'),
	(70, 'Joker Stencil', 'X1 Mult for each empty Joker slot. Joker Stencil included (Currently X1)', 8, 'Uncommon', 'X Mult'),
	(71, 'Jolly Joker', '+8 Mult if played hand contains a Pair', 3, 'Common', '+ Mult'),
	(72, 'Juggler', '+1 hand size', 4, 'Common', 'Other'),
	(73, 'Loyalty Card', 'X4 Mult every 6 hands played', 5, 'Uncommon', 'X Mult'),
	(74, 'Luchador', 'Sell this card to disable the current Boss Blind', 5, 'Uncommon', 'Other'),
	(75, 'Lucky Cat', 'This Joker gains X0.25 Mult every time a Lucky card successfully triggers', 6, 'Uncommon', 'X Mult'),
	(76, 'Lusty Joker', 'Played cards with  Heart suit give +3 Mult when scored', 5, 'Common', '+ Mult'),
	(77, 'Mad Joker', '+10 Mult if played hand contains a Two Pair', 4, 'Common', '+ Mult'),
	(78, 'Madness', 'When Small Blind or Big Blind is selected, gain X0.5 Mult and destroy a random Joker', 7, 'Uncommon', 'X Mult'),
	(79, 'Mail-In Rebate', 'Earn $5 for each discarded [rank], rank changes every round', 4, 'Common', 'Economy'),
	(80, 'Marble Joker', 'Adds one Stone card to the deck when Blind is selected', 6, 'Uncommon', 'Other'),
	(81, 'Matador', 'Earn $8 if played hand triggers the Boss Blind ability', 7, 'Uncommon', 'Economy'),
	(82, 'Merry Andy', '+3 discards each round, -1 hand size', 7, 'Uncommon', 'Other'),
	(83, 'Midas Mask', 'All played face cards become Gold cards when scored', 7, 'Uncommon', 'Other'),
	(84, 'Mime', 'Retrigger all card held in hand abilities', 5, 'Uncommon', 'Retrigger/Copy'),
	(85, 'Misprint', '+0-23 Mult', 4, 'Common', '+ Mult'),
	(86, 'Mr. Bones', 'Prevents Death if chips scored are at least 25% of required chips self destructs', 5, 'Uncommon', 'Other'),
	(87, 'Mystic Summit', '+15 Mult when 0 discards remaining', 5, 'Common', '+ Mult'),
	(88, 'Obelisk', 'This Joker gains X0.2 Mult per consecutive hand played without playing your most played poker hand', 8, 'Rare', 'X Mult'),
	(89, 'Odd Todd', 'Played cards with odd rank give +31 Chips when scored (A, 9, 7, 5, 3)', 4, 'Common', '+ Chips'),
	(90, 'Onyx Agate', 'Played cards with  Club suit give +7 Mult when scored', 7, 'Uncommon', '+ Mult'),
	(91, 'Oops! All 6s', 'Doubles all listed probabilities (ex: 1 in 3 -> 2 in 3)', 4, 'Uncommon', 'Other'),
	(92, 'Pareidolia', 'All cards are considered face cards', 5, 'Uncommon', 'Other'),
	(93, 'Perkeo', 'Creates a Negative copy of 1 random consumable card in your possession at the end of the shop', 20, 'Legendary', 'Other'),
	(94, 'Photograph', 'First played face card gives X2 Mult when scored', 5, 'Common', 'X Mult'),
	(95, 'Popcorn', '+20 Mult -4 Mult per round played', 5, 'Common', '+ Mult'),
	(96, 'Raised Fist', 'Adds double the rank of lowest ranked card held in hand to Mult', 5, 'Common', '+ Mult'),
	(97, 'Ramen', 'X2 Mult, loses X0.01 Mult per card discarded', 6, 'Uncommon', 'X Mult'),
	(98, 'Red Card', 'This Joker gains +3 Mult when any Booster Pack is skipped', 5, 'Common', '+ Mult'),
	(99, 'Reserved Parking', 'Each face card held in hand has a 1 in 2 chance to give $1', 6, 'Common', 'Economy'),
	(100, 'Ride the Bus', 'This Joker gains +1 Mult per consecutive hand played without a scoring face card', 6, 'Common', '+ Mult'),
	(101, 'Riff-Raff', 'When Blind is selected, create 2 Common Jokers (Must have room)', 6, 'Common', 'Other'),
	(102, 'Rocket', 'Earn $1 at end of round. Payout increases by $2 when Boss Blind is defeated', 6, 'Uncommon', 'Economy'),
	(103, 'Rough Gem', 'Played cards with  Diamond suit earn $1 when scored', 7, 'Uncommon', 'Economy'),
	(104, 'Runner', 'Gains +15 Chips if played hand contains a Straight', 5, 'Common', '+ Chips'),
	(105, 'Satellite', 'Earn $1 at end of round per unique Planet card used this run', 6, 'Uncommon', 'Economy'),
	(106, 'Scary Face', 'Played face cards give +30 Chips when scored', 4, 'Common', '+ Chips'),
	(107, 'Scholar', 'Played Aces give +20 Chips and +4 Mult when scored', 4, 'Common', '+ Mult + Chips'),
	(108, 'Seance', 'If poker hand is a Straight Flush, create a random Spectral card (Must have room)', 6, 'Uncommon', 'Other'),
	(109, 'Seeing Double', 'X2 Mult if played hand has a scoring  Club card and a scoring card of any other suit', 6, 'Uncommon', 'X Mult'),
	(110, 'Seltzer', 'Retrigger all cards played for the next 10 hands', 6, 'Uncommon', 'Retrigger/Copy'),
	(111, 'Shoot the Moon', 'Each Queen held in hand gives +13 Mult', 5, 'Common', '+ Mult'),
	(112, 'Shortcut', 'Allows Straights to be made with gaps of 1 rank (ex: 10 8 6 5 3)', 7, 'Uncommon', 'Other'),
	(113, 'Showman', 'Joker, Tarot, Planet, and Spectral cards may appear multiple times', 5, 'Uncommon', 'Other'),
	(114, 'Sixth Sense', 'If first hand of round is a single 6, destroy it and create a Spectral card (Must have room)', 6, 'Uncommon', 'Other'),
	(115, 'Sly Joker', '+50 Chips if played hand contains a Pair', 3, 'Common', '+ Chips'),
	(116, 'Smeared Joker', ' Hearts and  Diamonds count as the same suit,  Spades and  Clubs count as the same suit', 7, 'Uncommon', 'Other'),
	(117, 'Smiley Face', 'Played face cards give +5 Mult when scored', 4, 'Common', '+ Mult'),
	(118, 'Sock and Buskin', 'Retrigger all played face cards', 6, 'Uncommon', 'Retrigger/Copy'),
	(119, 'Space Joker', '1 in 4 chance to upgrade level of played poker hand', 5, 'Uncommon', 'Other'),
	(120, 'Spare Trousers', 'This Joker gains +2 Mult if played hand contains a Two Pair', 6, 'Uncommon', '+ Mult'),
	(121, 'Splash', 'Every played card counts in scoring', 3, 'Common', 'Other'),
	(122, 'Square Joker', 'This Joker gains +4 Chips if played hand has exactly 4 cards', 4, 'Common', '+ Chips'),
	(123, 'Steel Joker', 'Gives X0.2 Mult for each Steel Card in your full deck', 7, 'Uncommon', 'X Mult'),
	(124, 'Stone Joker', 'Gives +25 Chips for each Stone Card in your full deck', 6, 'Uncommon', '+ Chips'),
	(125, 'Stuntman', '+250 Chips, -2 hand size', 7, 'Rare', '+ Chips'),
	(126, 'Supernova', 'Adds the number of times poker hand has been played this run to Mult', 5, 'Common', '+ Mult'),
	(127, 'Superposition', 'Create a Tarot card if poker hand contains an Ace and a Straight', 4, 'Common', 'Other'),
	(128, 'Swashbuckler', 'Adds the sell value of all other owned Jokers to Mult', 4, 'Common', '+ Mult'),
	(129, 'The Duo', 'X2 Mult if played hand contains a Pair', 8, 'Rare', 'X Mult'),
	(130, 'The Family', 'X4 Mult if played hand contains a Four of a Kind', 8, 'Rare', 'X Mult'),
	(131, 'The Idol', 'Each played [rank] of [suit] gives X2 Mult when scored Card changes every round', 6, 'Uncommon', 'X Mult'),
	(132, 'The Order', 'X3 Mult if played hand contains a Straight', 8, 'Rare', 'X Mult'),
	(133, 'The Tribe', 'X2 Mult if played hand contains a Flush', 8, 'Rare', 'X Mult'),
	(134, 'The Trio', 'X3 Mult if played hand contains a Three of a Kind', 8, 'Rare', 'X Mult'),
	(135, 'Throwback', 'X0.25 Mult for each Blind skipped this run', 6, 'Uncommon', 'X Mult'),
	(136, 'To Do List', 'Earn $4 if poker hand is a [Poker Hand], poker hand changes at end of round', 4, 'Common', 'Economy'),
	(137, 'To the Moon', 'Earn an extra $1 of interest for every $5 you have at end of round', 5, 'Uncommon', 'Economy'),
	(138, 'Trading Card', 'If first discard of round has only 1 card, destroy it and earn $3', 6, 'Uncommon', 'Economy'),
	(139, 'Triboulet', 'Played Kings and Queens each give X2 Mult when scored', 20, 'Legendary', 'X Mult'),
	(140, 'Troubadour', '+2 hand size, -1 hand per round', 6, 'Uncommon', 'Other'),
	(141, 'Turtle Bean', '+5 hand size, reduces by 1 each round', 6, 'Uncommon', 'Other'),
	(142, 'Vagabond', 'Create a Tarot card if hand is played with $4 or less', 8, 'Rare', 'Other'),
	(143, 'Vampire', 'This Joker gains X0.1 Mult per scoring Enhanced card played, removes card Enhancement', 7, 'Uncommon', 'X Mult'),
	(144, 'Walkie Talkie', 'Each played 10 or 4 gives +10 Chips and +4 Mult when scored', 4, 'Common', '+ Mult + Chips'),
	(145, 'Wee Joker', 'This Joker gains +8 Chips when each played 2 is scored', 8, 'Rare', '+ Chips'),
	(146, 'Wily Joker', '+100 Chips if played hand contains a Three of a Kind', 4, 'Common', '+ Chips'),
	(147, 'Wrathful Joker', 'Played cards with  Spade suit give +3 Mult when scored', 5, 'Common', '+ Mult'),
	(148, 'Yorick', 'This Joker gains X1 Mult every 23 cards discarded', 20, 'Legendary', 'X Mult'),
	(149, 'Zany Joker', '+12 Mult if played hand contains a Three of a Kind', 4, 'Common', '+ Mult')
;
GO