﻿Imports MirageBasic.Core.Database

Public Module modTypes
    ' Common data structure arrays
    Public Job(MAX_JOBS) As JobStruct
    Public Item(MAX_ITEMS) As ItemStruct
    Public Npc(MAX_NPCS) As NpcStruct
    Public Shop(MAX_SHOPS) As ShopStruct
    Public Skill(MAX_SKILLS) As SkillStruct
    Public Resource(MAX_RESOURCES) As ResourceStruct
    Public Animation(MAX_ANIMATIONS) As AnimationStruct
    Public Map(MAX_CACHED_MAPS) As MapStruct
    Public PlayersOnMap(MAX_CACHED_MAPS) As Integer
    Public MapItem(MAX_CACHED_MAPS, MAX_MAP_ITEMS) As MapItemStruct
    Public MapNpc(MAX_MAP_NPCS) As MapDataStruct
    Public Bank(MAX_PLAYERS) As BankStruct
    Public TempPlayer(MAX_PLAYERS) As TempPlayerStruct
    Public Player(MAX_PLAYERS) As PlayerStruct
    Public InstancedMaps(MAX_INSTANCED_MAPS) As InstancedMap
    Public CharSelection() As CharSelStruct
    Public House() As HouseStruct
    Public HouseConfig() As HouseStruct
    Public Furniture() As FurnitureStruct
    Public Quest(MAX_QUESTS) As QuestStruct
    Public Projectile(MAX_PROJECTILES) As ProjectileStruct
    Public MapProjectile(MAX_PROJECTILES) As MapProjectileStruct
    Public TradeYourOffer(MAX_INV) As PlayerInvStruct
    Public TradeTheirOffer(MAX_INV) As PlayerInvStruct
    Public Party As PartyStruct
    Public MapResource() As MapResourceStruct
    Public CharactersList As CharacterList

    ' Common data structures
    Public Structure RandInvStruct
        Dim Prefix As String
        Dim Suffix As String
        Dim Stat() As Integer
        Dim Rarity As Integer
        Dim Damage As Integer
        Dim Speed As Integer
    End Structure

    Public Structure ResourceSkillsStruct
        Dim SkillLevel As Integer
        Dim SkillCurExp As Integer
        Dim SkillNextLvlExp As Integer
    End Structure

    Public Structure AnimationStruct
        Dim Name As String
        Dim Sound As String
        Dim Sprite() As Integer
        Dim Frames() As Integer
        Dim LoopCount() As Integer
        Dim LoopTime() As Integer
    End Structure

    Public Structure Rect
        Dim Top As Integer
        Dim Left As Integer
        Dim Right As Integer
        Dim Bottom As Integer
    End Structure

    Public Structure ResourceStruct
        Dim Name As String
        Dim SuccessMessage As String
        Dim EmptyMessage As String
        Dim ResourceType As Integer
        Dim ResourceImage As Integer
        Dim ExhaustedImage As Integer
        Dim ExpReward As Integer
        Dim ItemReward As Integer
        Dim LvlRequired As Integer
        Dim ToolRequired As Integer
        Dim Health As Integer
        Dim RespawnTime As Integer
        Dim Walkthrough As Boolean
        Dim Animation As Integer
    End Structure

    Public Structure SkillStruct
        Dim Name As String
        Dim Type As Byte
        Dim MpCost As Integer
        Dim LevelReq As Integer
        Dim AccessReq As Integer
        Dim JobReq As Integer
        Dim CastTime As Integer
        Dim CdTime As Integer
        Dim Icon As Integer
        Dim Map As Integer
        Dim X As Integer
        Dim Y As Integer
        Dim Dir As Byte
        Dim Vital As Integer
        Dim Duration As Integer
        Dim Interval As Integer
        Dim Range As Integer
        Dim IsAoE As Boolean
        Dim AoE As Integer
        Dim CastAnim As Integer
        Dim SkillAnim As Integer
        Dim StunDuration As Integer

        'projectiles
        Dim IsProjectile As Integer '0 is no, 1 is yes
        Dim Projectile As Integer

        Dim KnockBack As Byte '0 is no, 1 is yes
        Dim KnockBackTiles As Byte
    End Structure

    Public Structure ShopStruct
        Dim Name As String
        Dim Face As Byte
        Dim BuyRate As Integer
        Dim TradeItem() As TradeItemStruct
    End Structure

    Public Structure PlayerInvStruct
        Dim Num As Integer
        Dim Value As Integer
    End Structure

    Public Structure PlayerSkillStruct
        Dim Num As Integer
        Dim CD As Integer
    End Structure

    Public Structure BankStruct
        Dim Item() As PlayerInvStruct
        Dim ItemRand() As RandInvStruct
    End Structure

    Public Structure TileDataStruct
        Dim X As Byte
        Dim Y As Byte
        Dim Tileset As Byte
        Dim AutoTile As Byte
    End Structure

    Public Structure TileStruct
        Dim Layer() As TileDataStruct
        Dim Type As Byte
        Dim Data1 As Integer
        Dim Data2 As Integer
        Dim Data3 As Integer
        Dim DirBlock As Byte
    End Structure

    Public Structure ItemStruct
        Dim Name As String
        Dim Pic As Integer
        Dim Description As String

        Dim Type As Byte
        Dim SubType As Byte
        Dim Data1 As Integer
        Dim Data2 As Integer
        Dim Data3 As Integer
        Dim JobReq As Integer
        Dim AccessReq As Integer
        Dim LevelReq As Integer
        Dim Mastery As Byte
        Dim Price As Integer
        Dim Add_Stat() As Byte
        Dim Rarity As Byte
        Dim Speed As Integer
        Dim TwoHanded As Integer
        Dim BindType As Byte
        Dim Stat_Req() As Byte
        Dim Animation As Integer
        Dim Paperdoll As Integer

        Dim Randomize As Byte
        Dim RandomMin As Byte
        Dim RandomMax As Byte

        Dim Stackable As Byte
        Dim ItemLevel As Byte

        'Housing
        Dim FurnitureWidth As Integer
        Dim FurnitureHeight As Integer
        Dim FurnitureBlocks(,) As Integer
        Dim FurnitureFringe(,) As Integer

        Dim KnockBack As Byte
        Dim KnockBackTiles As Byte

        Dim Projectile As Integer
        Dim Ammo As Integer
    End Structure

    Public Structure AnimInstanceStruct
        Dim Animation As Integer
        Dim X As Integer
        Dim Y As Integer
        ' used for locking to players/npcs
        Dim lockindex As Integer
        Dim LockType As Byte
        ' timing
        Dim Timer() As Integer
        ' rendering check
        Dim Used() As Boolean
        ' counting the loop
        Dim LoopIndex() As Integer
        Dim FrameIndex() As Integer
    End Structure

    Public Structure NpcStruct
        Dim Name As String
        Dim AttackSay As String
        Dim Sprite As Integer
        Dim SpawnTime As Byte
        Dim SpawnSecs As Integer
        Dim Behaviour As Byte
        Dim Range As Byte
        Dim DropChance() As Integer
        Dim DropItem() As Integer
        Dim DropItemValue() As Integer
        Dim Stat() As Byte
        Dim Faction As Byte
        Dim HP As Integer
        Dim Exp As Integer
        Dim Animation As Integer
        Dim QuestNum As Integer
        Dim Skill() As Byte

        Dim Level As Integer
        Dim Damage As Integer
    End Structure

    Public Structure TradeItemStruct
        Dim Item As Integer
        Dim ItemValue As Integer
        Dim CostItem As Integer
        Dim CostValue As Integer
    End Structure

    Public Structure JobStruct
        Dim Name As String
        Dim Desc As String
        Dim Stat() As Byte
        Dim MaleSprite() As Integer
        Dim FemaleSprite() As Integer
        Dim StartItem() As Integer
        Dim StartValue() As Integer
        Dim StartMap As Integer
        Dim StartX As Byte
        Dim StartY As Byte
        Dim BaseExp As Integer

        ' For client use
        Dim Vital() As Integer
    End Structure

    Public Structure PetStruct
        Dim Num As Integer
        Dim Name As String
        Dim Sprite As Integer

        Dim Range As Integer

        Dim Level As Integer

        Dim MaxLevel As Integer
        Dim ExpGain As Integer
        Dim LevelPnts As Integer

        Dim StatType As Byte '1 for set stats, 2 for relation to owner's stats
        Dim LevelingType As Byte '0 for leveling on own, 1 for not leveling

        Dim Stat() As Byte

        Dim Skill() As Integer

        Dim Evolvable As Byte
        Dim EvolveLevel As Integer
        Dim EvolveNum As Integer
    End Structure

    Public Structure PlayerPetStruct
        Dim Num As Integer
        Dim Health As Integer
        Dim Mana As Integer
        Dim Level As Integer
        Dim Stat() As Byte
        Dim Skill() As Integer
        Dim Points As Integer
        Dim X As Integer
        Dim Y As Integer
        Dim Dir As Integer
        Dim MaxHp As Integer
        Dim MaxMp As Integer
        Dim Alive As Byte
        Dim AttackBehaviour As Integer
        Dim AdoptiveStats As Integer
        Dim Exp As Integer
        Dim Tnl As Integer

        'Client Use Only
        Dim XOffset As Integer

        Dim YOffset As Integer
        Dim Moving As Byte
        Dim Attacking As Byte
        Dim AttackTimer As Integer
        Dim Steps As Byte
        Dim Damage As Integer
    End Structure

    Public Structure PlayerStruct
        ' Account
        Dim Login As String
        Dim Password As String
        Dim Access As Byte

        ' General
        Dim Name As String

        Dim Sex As Byte
        Dim Job As Byte
        Dim Sprite As Integer
        Dim Level As Byte
        Dim Exp As Integer

        Dim Pk As Byte

        ' Vitals
        Dim Vital() As Integer

        ' Stats
        Dim Stat() As Byte

        Dim Points As Byte

        ' Worn equipment
        Dim Equipment() As Integer

        ' Inventory
        Dim Inv() As PlayerInvStruct

        Dim Skill() As PlayerSKillStruct

        ' Position
        Dim Map As Integer

        Dim X As Byte
        Dim Y As Byte
        Dim Dir As Byte

        Dim PlayerQuest() As PlayerQuestStruct

        'Housing
        Dim House As PlayerHouseStruct

        Dim InHouse As Integer
        Dim LastMap As Integer
        Dim LastX As Integer
        Dim LastY As Integer

        'Hotbar
        Dim Hotbar() As HotbarStruct

        'Event
        Dim Switches() As Byte

        Dim Variables() As Integer

        'gather skills
        Dim GatherSkills() As ResourceSkillsStruct

        Dim RecipeLearned() As Byte

        ' Random Items
        Dim RandInv() As RandInvStruct

        Dim RandEquip() As RandInvStruct

        Dim Pet As PlayerPetStruct

        Dim XOffset As Integer
        Dim YOffset As Integer
        Dim Moving As Byte
        Dim Attacking As Byte
        Dim AttackTimer As Integer
        Dim MapGetTimer As Integer
        Dim Steps As Byte

        Dim Emote As Integer
        Dim EmoteTimer As Integer
        Dim EventTimer As Integer
    End Structure

    Public Structure TempPlayerStruct
        ' Non saved local vars
        Dim InGame As Boolean

        Dim AttackTimer As Integer
        Dim DataTimer As Integer
        Dim DataBytes As Integer
        Dim DataPackets As Integer
        Dim PartyInvite As Integer
        Dim InParty As Byte
        Dim TargetType As Byte
        Dim Target As Integer
        Dim PartyStarter As Byte
        Dim GettingMap As Byte
        Dim SkillBuffer As Integer
        Dim SkillBufferTimer As Integer
        Dim SkillCd() As Integer
        Dim InShop As Integer
        Dim StunTimer As Integer
        Dim StunDuration As Integer
        Dim InBank As Boolean

        ' trade
        Dim TradeRequest As Integer

        Dim InTrade As Integer
        Dim TradeOffer() As PlayerInvStruct
        Dim AcceptTrade As Boolean

        'Housing
        Dim BuyHouseindex As Integer

        Dim Invitationindex As Integer
        Dim InvitationTimer As Integer

        Dim EventMap As EventMapStruct
        Dim EventProcessingCount As Integer
        Dim EventProcessing() As EventProcessingStruct

        'craft shit
        Dim IsCrafting As Boolean

        Dim CraftIt As Byte
        Dim CraftTimer As Integer
        Dim CraftTimeNeeded As Integer

        Dim CraftRecipe As Integer
        Dim CraftAmount As Integer

        Dim StopRegenTimer As Integer
        Dim StopRegen As Byte

        'instance stuff
        Dim InInstance As Byte

        Dim TmpInstanceNum As Integer
        Dim TmpMap As Integer
        Dim TmpX As Integer
        Dim TmpY As Integer

        'pets
        Dim PetTarget As Integer

        Dim PetTargetType As Integer
        Dim PetBehavior As Integer

        Dim GoToX As Integer
        Dim GoToY As Integer

        Dim PetStunTimer As Integer
        Dim PetStunDuration As Integer
        Dim PetAttackTimer As Integer

        Dim PetSkillCd() As Integer
        Dim PetskillBuffer As SkillBufferRec

        Dim PetDoT() As DoTRStruct
        Dim PetHoT() As DoTRStruct

        ' regen
        Dim PetstopRegen As Boolean

        Dim PetstopRegenTimer As Integer

        Dim Editor As Integer

    End Structure

    Public Structure MapStruct
        Dim Name As String
        Dim Music As String

        Dim Revision As Integer
        Dim Moral As Byte
        Dim Tileset As Integer

        Dim Up As Integer
        Dim Down As Integer
        Dim Left As Integer
        Dim Right As Integer

        Dim BootMap As Integer
        Dim BootX As Byte
        Dim BootY As Byte

        Dim MaxX As Byte
        Dim MaxY As Byte

        Dim Tile(,) As TileStruct

        Dim Npc() As Integer

        Dim EventCount As Integer
        Dim Events() As EventStruct

        Dim WeatherType As Byte
        Dim Fogindex As Integer
        Dim WeatherIntensity As Integer
        Dim FogAlpha As Byte
        Dim FogSpeed As Byte

        Dim HasMapTint As Byte
        Dim MapTintR As Byte
        Dim MapTintG As Byte
        Dim MapTintB As Byte
        Dim MapTintA As Byte

        Dim Instanced As Byte

        Dim Panorama As Byte
        Dim Parallax As Byte
    End Structure

    Public Structure MapItemStruct
        Dim Num As Integer
        Dim Value As Integer
        Dim X As Byte
        Dim Y As Byte

        Dim RandData As RandInvStruct

        ' ownership + despawn
        Dim PlayerName As String

        Dim PlayerTimer As Long
        Dim CanDespawn As Boolean
        Dim DespawnTimer As Long
    End Structure

    Public Structure MapNpcStruct
        Dim Num As Integer
        Dim Target As Integer
        Dim TargetType As Byte
        Dim Vital() As Integer
        Dim X As Byte
        Dim Y As Byte
        Dim Dir As Integer

        ' For server use only
        Dim SpawnWait As Integer

        Dim AttackTimer As Integer
        Dim StunDuration As Integer
        Dim StunTimer As Integer
        Dim SkillBuffer As Integer
        Dim SkillBufferTimer As Integer
        Dim SkillCd() As Integer
        Dim StopRegen As Byte
        Dim StopRegenTimer As Integer
    End Structure
    Public Structure MapDataStruct
        Dim Npc() As MapNpcStruct
    End Structure

    Public Structure HotbarStruct
        Dim Slot As Integer
        Dim SlotType As Byte
    End Structure

    Public Structure SkillBufferRec
        Dim Skill As Integer
        Dim Timer As Integer
        Dim Target As Integer
        Dim TargetTypes As Byte
    End Structure

    Public Structure DoTRStruct
        Dim Used As Boolean
        Dim Skill As Integer
        Dim Timer As Integer
        Dim Caster As Integer
        Dim StartTime As Integer

        'PET
        Dim AttackerType As Integer 'For Pets

    End Structure

    Public Structure InstancedMap
        Dim OriginalMap As Integer
    End Structure

    Public Structure MoveRouteStruct
        Dim Index As Integer
        Dim Data1 As Integer
        Dim Data2 As Integer
        Dim Data3 As Integer
        Dim Data4 As Integer
        Dim Data5 As Integer
        Dim Data6 As Integer
    End Structure

    Public Structure GlobalEventStruct
        Dim X As Integer
        Dim Y As Integer
        Dim Dir As Integer
        Dim Active As Integer

        Dim WalkingAnim As Integer
        Dim FixedDir As Integer
        Dim WalkThrough As Integer
        Dim ShowName As Integer

        Dim Position As Integer

        Dim GraphicType As Byte
        Dim Graphic As Integer
        Dim GraphicX As Integer
        Dim GraphicX2 As Integer
        Dim GraphicY As Integer
        Dim GraphicY2 As Integer

        'Server Only Options
        Dim MoveType As Integer

        Dim MoveSpeed As Byte
        Dim MoveFreq As Byte
        Dim MoveRouteCount As Integer
        Dim MoveRoute() As MoveRouteStruct
        Dim MoveRouteStep As Integer

        Dim RepeatMoveRoute As Integer
        Dim IgnoreIfCannotMove As Integer

        Dim MoveTimer As Integer
        Dim QuestNum As Integer
        Dim MoveRouteComplete As Integer
    End Structure

    Public Structure GlobalEventsStruct
        Dim EventCount As Integer
        Dim Events() As GlobalEventStruct
    End Structure

    Public Structure ConditionalBranchStruct
        Dim Condition As Integer
        Dim Data1 As Integer
        Dim Data2 As Integer
        Dim Data3 As Integer
        Dim CommandList As Integer
        Dim ElseCommandList As Integer
    End Structure

    Public Structure EventCommandStruct
        Dim Index As Byte
        Dim Text1 As String
        Dim Text2 As String
        Dim Text3 As String
        Dim Text4 As String
        Dim Text5 As String
        Dim Data1 As Integer
        Dim Data2 As Integer
        Dim Data3 As Integer
        Dim Data4 As Integer
        Dim Data5 As Integer
        Dim Data6 As Integer
        Dim ConditionalBranch As ConditionalBranchStruct
        Dim MoveRouteCount As Integer
        Dim MoveRoute() As MoveRouteStruct
    End Structure

    Public Structure CommandListStruct
        Dim CommandCount As Integer
        Dim ParentList As Integer
        Dim Commands() As EventCommandStruct
    End Structure

    Public Structure EventPageStruct

        'These are condition variables that decide if the event even appears to the player.
        Dim ChkVariable As Integer

        Dim Variableindex As Integer
        Dim VariableCondition As Integer
        Dim VariableCompare As Integer

        Dim ChkSwitch As Integer
        Dim Switchindex As Integer
        Dim SwitchCompare As Integer

        Dim ChkHasItem As Integer
        Dim HasItemindex As Integer
        Dim HasItemAmount As Integer

        Dim ChkSelfSwitch As Integer
        Dim SelfSwitchindex As Integer
        Dim SelfSwitchCompare As Integer

        'Handles the Event Sprite
        Dim GraphicType As Byte

        Dim Graphic As Integer
        Dim GraphicX As Integer
        Dim GraphicY As Integer
        Dim GraphicX2 As Integer
        Dim GraphicY2 As Integer

        'Handles Movement - Move Routes to come soon.
        Dim MoveType As Byte
        Dim MoveSpeed As Byte
        Dim MoveFreq As Byte
        Dim MoveRouteCount As Integer
        Dim MoveRoute() As MoveRouteStruct
        Dim IgnoreMoveRoute As Integer
        Dim RepeatMoveRoute As Integer

        'Guidelines for the event
        Dim WalkAnim As Integer

        Dim DirFix As Integer
        Dim WalkThrough As Integer
        Dim ShowName As Integer

        'Trigger for the event
        Dim Trigger As Byte

        'Commands for the event
        Dim CommandListCount As Integer

        Dim CommandList() As CommandListStruct

        Dim Position As Byte

        Dim QuestNum As Integer

        'For EventMap
        Dim X As Integer

        Dim Y As Integer
    End Structure

    Public Structure EventStruct
        Dim Name As String
        Dim Globals As Byte
        Dim PageCount As Integer
        Dim Pages() As EventPageStruct
        Dim X As Integer
        Dim Y As Integer

        'Self Switches re-set on restart.
        Dim SelfSwitches() As Integer '0 to 4

    End Structure

    Public Structure GlobalMapEventsStruct
        Dim EventId As Integer
        Dim PageId As Integer
        Dim X As Integer
        Dim Y As Integer
    End Structure

    Public Structure MapEventStruct
        Dim Name As String
        Dim Steps As Integer
        Dim Dir As Integer
        Dim X As Integer
        Dim Y As Integer

        Dim WalkingAnim As Integer
        Dim FixedDir As Integer
        Dim WalkThrough As Integer
        Dim ShowName As Integer

        Dim GraphicType As Byte
        Dim GraphicX As Integer
        Dim GraphicY As Integer
        Dim GraphicX2 As Integer
        Dim GraphicY2 As Integer
        Dim Graphic As Integer

        Dim MovementSpeed As Integer
        Dim Position As Integer
        Dim Visible As Integer
        Dim EventId As Integer
        Dim PageId As Integer

        Dim MoveType As Byte
        Dim MoveSpeed As Byte
        Dim MoveFreq As Byte
        Dim MoveRouteCount As Integer
        Dim MoveRoute() As MoveRouteStruct
        Dim MoveRouteStep As Integer

        Dim RepeatMoveRoute As Integer
        Dim IgnoreIfCannotMove As Integer
        Dim QuestNum As Integer

        Dim MoveTimer As Integer
        Dim SelfSwitches() As Integer '0 to 4
        Dim MoveRouteComplete As Integer

        Dim XOffset As Integer
        Dim YOffset As Integer
        Dim Moving As Integer
        Dim ShowDir As Integer
        Dim WalkAnim As Integer
        Dim DirFix As Integer
    End Structure

    Public Structure EventMapStruct
        Dim CurrentEvents As Integer
        Dim EventPages() As MapEventStruct
    End Structure

    Public Structure EventProcessingStruct
        Dim Active As Integer
        Dim CurList As Integer
        Dim CurSlot As Integer
        Dim EventId As Integer
        Dim PageId As Integer
        Dim WaitingForResponse As Integer
        Dim EventMovingId As Integer
        Dim EventMovingType As Integer
        Dim ActionTimer As Integer
        Dim ListLeftOff() As Integer
    End Structure

    Public Structure CharSelStruct
        Dim Name As String
        Dim Sprite As Integer
        Dim Gender As Integer
        Dim ClassName As String
        Dim Level As Integer
    End Structure

    Public Structure HouseStruct
        Dim ConfigName As String
        Dim BaseMap As Integer
        Dim Price As Integer
        Dim MaxFurniture As Integer
        Dim X As Integer
        Dim Y As Integer
    End Structure

    Public Structure FurnitureStruct
        Dim ItemNum As Integer
        Dim X As Integer
        Dim Y As Integer
    End Structure

    Public Structure PlayerHouseStruct
        Dim Houseindex As Integer
        Dim FurnitureCount As Integer
        Dim Furniture() As FurnitureStruct
    End Structure

    Public Structure PlayerQuestStruct
        Dim Status As Integer '0=not started, 1=started, 2=completed, 3=completed but repeatable
        Dim ActualTask As Integer
        Dim CurrentCount As Integer 'Used to handle the Amount property
    End Structure

    Public Structure TaskStruct
        Dim Order As Integer
        Dim Npc As Integer
        Dim Item As Integer
        Dim Map As Integer
        Dim Resource As Integer
        Dim Amount As Integer
        Dim Speech As String
        Dim TaskLog As String
        Dim QuestEnd As Byte
        Dim TaskType As Integer
    End Structure

    Public Structure QuestStruct
        Dim Name As String
        Dim QuestLog As String
        Dim Repeat As Byte
        Dim Cancelable As Byte

        Dim ReqCount As Integer
        Dim Requirement() As Integer '1=item, 2=quest, 3=class
        Dim RequirementIndex() As Integer

        Dim QuestGiveItem As Integer 'Todo: make this dynamic
        Dim QuestGiveItemValue As Integer
        Dim QuestRemoveItem As Integer
        Dim QuestRemoveItemValue As Integer

        Dim Chat() As String

        Dim RewardCount As Integer
        Dim RewardItem() As Integer
        Dim RewardItemAmount() As Integer
        Dim RewardExp As Integer

        Dim TaskCount As Integer
        Dim Task() As TaskStruct

    End Structure

    Public Structure ProjectileStruct
        Dim Name As String
        Dim Sprite As Integer
        Dim Range As Byte
        Dim Speed As Integer
        Dim Damage As Integer
    End Structure

    Public Structure MapProjectileStruct
        Dim ProjectileNum As Integer
        Dim Owner As Integer
        Dim OwnerType As Byte
        Dim X As Integer
        Dim Y As Integer
        Dim Dir As Byte
        Dim Range As Integer
        Dim TravelTime As Integer
        Dim Timer As Integer
    End Structure

    Public Structure EventListStruct
        Dim CommandList As Integer
        Dim CommandNum As Integer
    End Structure

    Public Structure PartyStruct
        Dim Leader As Integer
        Dim Member() As Integer
        Dim MemberCount As Integer
    End Structure

    Public Structure MapResourceStruct
        Dim ResourceCount As Integer
        Dim ResourceData() As MapResourceCacheStruct
    End Structure

    Public Structure MapResourceCacheStruct
        Dim X As Integer
        Dim Y As Integer
        Dim State As Byte
        Dim Timer As Integer
        Dim Health As Byte
    End Structure
End Module