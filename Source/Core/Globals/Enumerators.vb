Public Module Enumerations

    ''' <Summary> Text Color Contstant </Summary>
    Enum ColorType As Byte
        Black 
        Blue
        Green
        Cyan
        Red
        Magenta
        Brown
        Gray
        DarkGray
        BrightBlue
        BrightGreen
        BrightCyan
        BrightRed
        Pink
        Yellow
        White
    End Enum

    ''' <Summary> Quick Access/Constant Color References </Summary>
    Enum QColorType As Byte
        SayColor = ColorType.White
        GlobalColor = ColorType.BrightBlue
        BroadcastColor = ColorType.White
        TellColor = ColorType.BrightGreen
        EmoteColor = ColorType.BrightCyan
        AdminColor = ColorType.BrightCyan
        HelpColor = ColorType.BrightBlue
        WhoColor = ColorType.BrightBlue
        JoinLeftColor = ColorType.Gray
        NpcColor = ColorType.Brown
        AlertColor = ColorType.BrightRed
        NewMapColor = ColorType.BrightBlue
    End Enum

    ''' <Summary> Sex Constant </Summary>
    Enum SexType As Byte
        Male
        Female
    End Enum

    ''' <Summary> Map Moral Constant </Summary>
    Enum MapMoralType As Byte
        None
        Safe
        Indoors
    End Enum

    ''' <Summary> Tile Constant </Summary>
    Enum TileType As Byte
        None
        Blocked
        Warp
        Item
        NpcAvoid
        Resource
        NpcSpawn
        Shop
        Bank
        Heal
        Trap
        Craft
        Light

        Count
    End Enum

    ''' <Summary> Item Constant </Summary>
    Enum ItemType As Byte
        None
        Equipment
        Consumable
        CommonEvent
        Currency
        Skill
        Projectile    
        Pet

        Count
    End Enum

    ''' <Summary> Consumable Constant </Summary>
    Enum ConsumableType As Byte
        HP
        MP
        Sp
        Exp
    End Enum

    ''' <Summary> Direction Constant </Summary>
    Enum DirectionType As Byte
        Up
        Down
        Left
        Right
    End Enum

    ''' <Summary> Movement Constant </Summary>
    Enum MovementType As Byte
        Standing
        Walking
        Running
    End Enum

    ''' <Summary> Admin Constant </Summary>
    Enum AdminType As Byte
        Player
        Moderator
        Mapper
        Developer
        Creator
    End Enum

    ''' <Summary> Npc Behavior Constant </Summary>
    Enum NpcBehavior As Byte
        AttackOnSight
        AttackWhenAttacked
        Friendly
        ShopKeeper
        Guard
        Quest
    End Enum

    ''' <Summary> Skill Constant </Summary>
    Enum SkillType As Byte
        DamageHp
        DamageMp
        HealHp
        HealMp
        Warp
        Pet
    End Enum

    ''' <Summary> Target Constant </Summary>
    Enum TargetType As Byte
        None
        Player
        Npc
        [Event]
        Pet
    End Enum

    ''' <Summary> Action Message Constant </Summary>
    Enum ActionMsgType As Byte
        [Static]
        Scroll
        Screen
    End Enum

    ''' <Summary> Stats used by Players, Npcs and Class </Summary>
    Public Enum StatType As Byte
        Strength
        Endurance
        Vitality
        Luck
        Intelligence
        Spirit

        Count
    End Enum

    ''' <Summary> Vitals used by Players, Npcs, and Class </Summary>
    Public Enum VitalType As Byte
        HP
        MP
        SP

        Count
    End Enum

    ''' <Summary> Equipment used by Players </Summary>
    Public Enum EquipmentType As Byte
        Weapon
        Armor
        Helmet
        Shield
        Shoes
        Gloves

        Count
    End Enum

    ''' <Summary> Layers in a map </Summary>
    Public Enum LayerType As Byte
        Ground
        Mask
        Mask2
        Fringe
        Fringe2

        Count
    End Enum

    ''' <Summary> Resource Skills </Summary>
    Public Enum ResourceSkills As Byte
        Herbing
        Woodcutting
        Mining
        Fishing

        Count
    End Enum

    Public Enum RandomBonusType
        RANDOM_SPEED           ' Reduces time between attacks by 20%
        RANDOM_DAMAGE          ' Increases base damage by 25%
        RANDOM_WARRIOR         ' Adds Strength and Endurance
        RANDOM_ARCHER          ' Adds Achery and Endurance
        RANDOM_MAGE            ' Adds Magic and Endurance
        RANDOM_JESTER          ' Adds Magic and Archery
        RANDOM_BATTLEMAGE      ' Adds Attack and Magic
        RANDOM_ROGUE           ' Adds Attack and Archery
        RANDOM_TOWER           ' Adds Endurance and Defense
        RANDOM_SURVIVALIST     ' Adds Cooking and Fishing
        RANDOM_PERFECTIONIST   ' Adds Mining and Jeweler
        RANDOM_COALMEN         ' Adds Mining and Blacksmithing
        RANDOM_BOWYER          ' Adds Woodcutting and Fletching
        RANDOM_BROKEN          ' Reduces damage and increases speed by 10%
        RANDOM_PRISM           ' Gives four random stats, but will always turn soulbound
        RANDOM_CANNON          ' Gives Attack, Ranged and Magic
    End Enum

    Public Enum RarityType
        RARITY_BROKEN
        RARITY_COMMON
        RARITY_UNCOMMON
        RARITY_RARE
        RARITY_EPIC
    End Enum

    Public Enum WeatherType
        None
        Rain
        Snow
        Hail
        Sandstorm
        Storm
        Fog
    End Enum

    Public Enum QuestType
        Slay
        Collect
        Talk
        Reach
        Give
        Kill
        Gather
        Fetch
        TalkEvent
    End Enum

    Public Enum QuestStatusType
        NotStarted
        Started
        Completed
        Repeatable
    End Enum

    Public Enum MoveRouteOpts
        MoveUp
        MoveDown
        MoveLeft
        MoveRight
        MoveRandom
        MoveTowardsPlayer
        MoveAwayFromPlayer
        StepForward
        StepBack
        Wait100Ms
        Wait500Ms
        Wait1000Ms
        TurnUp
        TurnDown
        TurnLeft
        TurnRight
        Turn90Right
        Turn90Left
        Turn180
        TurnRandom
        TurnTowardPlayer
        TurnAwayFromPlayer
        SetSpeed8XSlower
        SetSpeed4XSlower
        SetSpeed2XSlower
        SetSpeedNormal
        SetSpeed2XFaster
        SetSpeed4XFaster
        SetFreqLowest
        SetFreqLower
        SetFreqNormal
        SetFreqHigher
        SetFreqHighest
        WalkingAnimOn
        WalkingAnimOff
        DirFixOn
        DirFixOff
        WalkThroughOn
        WalkThroughOff
        PositionBelowPlayer
        PositionWithPlayer
        PositionAbovePlayer
        ChangeGraphic
    End Enum

    ' Event Types
    Public Enum EventType
        ' Message
        AddText

        ShowText
        ShowChoices

        ' Game Progression
        PlayerVar

        PlayerSwitch
        SelfSwitch

        ' Flow Control
        Condition

        ExitProcess

        ' Player
        ChangeItems

        RestoreHP
        RestoreMP
        LevelUp
        ChangeLevel
        ChangeSkills
        ChangeJob
        ChangeSprite
        ChangeSex
        ChangePk

        ' Movement
        WarpPlayer

        SetMoveRoute

        ' Character
        PlayAnimation

        ' Music and Sounds
        PlayBgm

        FadeoutBgm
        PlaySound
        StopSound

        'Etc...
        CustomScript

        SetAccess

        'Shop/Bank
        OpenBank

        OpenShop

        'New
        GiveExp

        ShowChatBubble
        Label
        GotoLabel
        SpawnNpc
        FadeIn
        FadeOut
        FlashWhite
        SetFog
        SetWeather
        SetTint
        Wait
        OpenMail
        BeginQuest
        EndQuest
        QuestTask
        ShowPicture
        HidePicture
        WaitMovement
        HoldPlayer
        ReleasePlayer
    End Enum

    Public Enum CommonEventType
        Switch
        Variable
        Key
        CustomScript
    End Enum

    Public Enum EditorType
        Item
        Map
        NPC
        Skill
        Shop
        Resource
        Animation
        Pet
        Quest
        Job
        Projectile
    End Enum

End Module