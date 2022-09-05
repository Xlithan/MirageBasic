Imports System.IO
Imports MirageBasic.Core
Imports SFML.Audio
Imports SFML.Graphics

Module C_Editors

#Region "Animation Editor"

    Friend Sub AnimationEditorInit()
        With Animation(Editorindex)
            Editorindex = FrmEditor_Animation.lstIndex.SelectedIndex

            ' find the music we have set
            FrmEditor_Animation.cmbSound.Items.Clear()

            CacheSound
            For i = 0 To UBound(SoundCache)
                FrmEditor_Animation.cmbSound.Items.Add(SoundCache(i))
            Next

            If Trim$(Animation(Editorindex).Sound) = "" Then
                FrmEditor_Animation.cmbSound.SelectedIndex = 0
            Else
               For i = 0 To FrmEditor_Animation.cmbSound.Items.Count
                    If FrmEditor_Animation.cmbSound.GetItemText(i) = FrmEditor_Animation.cmbSound.SelectedIndex Then
                        FrmEditor_Animation.cmbSound.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If
            FrmEditor_Animation.txtName.Text = Trim$(.Name)

            FrmEditor_Animation.nudSprite0.Value = 0
            FrmEditor_Animation.nudFrameCount0.Value = .Frames(0)
            FrmEditor_Animation.nudLoopCount0.Value = .LoopCount(0)
            FrmEditor_Animation.nudLoopTime0.Value = .LoopTime(0)

            FrmEditor_Animation.nudSprite1.Value = 0
            FrmEditor_Animation.nudFrameCount1.Value = .Frames(1)
            FrmEditor_Animation.nudLoopCount1.Value = .LoopCount(1)
            FrmEditor_Animation.nudLoopTime1.Value = .LoopTime(1)
        End With

        EditorAnim_DrawAnim()
        Animation_Changed(Editorindex) = True
    End Sub

    Friend Sub AnimationEditorOk()
        Dim i As Integer

       For i = 0 To MAX_ANIMATIONS
            If Animation_Changed(i) Then
                SendSaveAnimation(i)
            End If
        Next

        FrmEditor_Animation.Visible = False
        Editor = -1
        ClearChanged_Animation()
    End Sub

    Friend Sub AnimationEditorCancel()
        Editor = -1
        FrmEditor_Animation.Visible = False
        ClearChanged_Animation()
        ClearAnimations()
        SendRequestAnimations()
    End Sub

    Friend Sub ClearChanged_Animation()
        For i = 0 To MAX_ANIMATIONS
            Animation_Changed(i) = False
        Next
    End Sub

#End Region

#Region "Npc Editor"

    Friend Sub NpcEditorInit()
        Dim i As Integer

        With frmEditor_NPC
            Editorindex = .lstIndex.SelectedIndex
            .cmbDropSlot.SelectedIndex = 0

            .txtName.Text = Trim$(Npc(Editorindex).Name)
            .txtAttackSay.Text = Trim$(Npc(Editorindex).AttackSay)
            .nudSprite.Value = Npc(Editorindex).Sprite
            .nudSpawnSecs.Value = Npc(Editorindex).SpawnSecs
            .cmbBehaviour.SelectedIndex = Npc(Editorindex).Behaviour
            .cmbFaction.SelectedIndex = Npc(Editorindex).Faction
            .nudRange.Value = Npc(Editorindex).Range
            .nudChance.Value = Npc(Editorindex).DropChance(frmEditor_NPC.cmbDropSlot.SelectedIndex)
            .cmbItem.SelectedIndex = Npc(Editorindex).DropItem(frmEditor_NPC.cmbDropSlot.SelectedIndex)

            .nudAmount.Value = Npc(Editorindex).DropItemValue(frmEditor_NPC.cmbDropSlot.SelectedIndex)

            .nudHp.Value = Npc(Editorindex).HP
            .nudExp.Value = Npc(Editorindex).Exp
            .nudLevel.Value = Npc(Editorindex).Level
            .nudDamage.Value = Npc(Editorindex).Damage

            .cmbQuest.SelectedIndex = Npc(Editorindex).QuestNum
            .cmbSpawnPeriod.SelectedIndex = Npc(Editorindex).SpawnTime

            .nudStrength.Value = Npc(Editorindex).Stat(StatType.Strength)
            .nudEndurance.Value = Npc(Editorindex).Stat(StatType.Endurance)
            .nudIntelligence.Value = Npc(Editorindex).Stat(StatType.Intelligence)
            .nudSpirit.Value = Npc(Editorindex).Stat(StatType.Spirit)
            .nudLuck.Value = Npc(Editorindex).Stat(StatType.Luck)
            .nudVitality.Value = Npc(Editorindex).Stat(StatType.Vitality)

            .cmbSkill1.SelectedIndex = Npc(Editorindex).Skill(1)
            .cmbSkill2.SelectedIndex = Npc(Editorindex).Skill(2)
            .cmbSkill3.SelectedIndex = Npc(Editorindex).Skill(3)
            .cmbSkill4.SelectedIndex = Npc(Editorindex).Skill(4)
            .cmbSkill5.SelectedIndex = Npc(Editorindex).Skill(5)
            .cmbSkill6.SelectedIndex = Npc(Editorindex).Skill(6)
        End With

        EditorNpc_DrawSprite()
        NPC_Changed(Editorindex) = True
    End Sub

    Friend Sub NpcEditorOk()
        Dim i As Integer

       For i = 0 To MAX_NPCS
            If NPC_Changed(i) Then
                SendSaveNpc(i)
            End If
        Next

        frmEditor_NPC.Visible = False
        Editor = -1
        ClearChanged_NPC()
    End Sub

    Friend Sub NpcEditorCancel()
        Editor = -1
        frmEditor_NPC.Visible = False
        ClearChanged_NPC()
        ClearNpcs()
        SendRequestNpcs()
    End Sub

    Friend Sub ClearChanged_NPC()
       For i = 0 To MAX_NPCS
            NPC_Changed(i) = False
        Next
    End Sub

#End Region

#Region "Resource Editor"
    Friend Sub ClearChanged_Resource()
        ReDim Resource_Changed(MAX_RESOURCES)
    End Sub

    Friend Sub ResourceEditorInit()
        Dim i As Integer

        Editorindex = frmEditor_Resource.lstIndex.SelectedIndex

        With frmEditor_Resource
            'populate combo boxes
            .cmbRewardItem.Items.Clear()
           For i = 0 To MAX_ITEMS
                .cmbRewardItem.Items.Add(i & ": " & Item(i).Name)
            Next

            .cmbAnimation.Items.Clear()
           For i = 0 To MAX_ANIMATIONS
                .cmbAnimation.Items.Add(i & ": " & Animation(i).Name)
            Next

            .nudExhaustedPic.Maximum = NumResources
            .nudNormalPic.Maximum = NumResources
            .nudRespawn.Maximum = 1000000
            .txtName.Text = Trim$(Resource(Editorindex).Name)
            .txtMessage.Text = Trim$(Resource(Editorindex).SuccessMessage)
            .txtMessage2.Text = Trim$(Resource(Editorindex).EmptyMessage)
            .cmbType.SelectedIndex = Resource(Editorindex).ResourceType
            .nudNormalPic.Value = Resource(Editorindex).ResourceImage
            .nudExhaustedPic.Value = Resource(Editorindex).ExhaustedImage
            .cmbRewardItem.SelectedIndex = Resource(Editorindex).ItemReward
            .nudRewardExp.Value = Resource(Editorindex).ExpReward
            .cmbTool.SelectedIndex = Resource(Editorindex).ToolRequired
            .nudHealth.Value = Resource(Editorindex).Health
            .nudRespawn.Value = Resource(Editorindex).RespawnTime
            .cmbAnimation.SelectedIndex = Resource(Editorindex).Animation
            .nudLvlReq.Value = Resource(Editorindex).LvlRequired
        End With

        frmEditor_Resource.Visible = True

        EditorResource_DrawSprite()

        Resource_Changed(Editorindex) = True
    End Sub

    Friend Sub ResourceEditorOk()
        Dim i As Integer

       For i = 0 To MAX_RESOURCES
            If Resource_Changed(i) Then
                SendSaveResource(i)
            End If
        Next

        frmEditor_Resource.Visible = False
        Editor = -1
        ClearChanged_Resource()
    End Sub

    Friend Sub ResourceEditorCancel()
        Editor = -1
        frmEditor_Resource.Visible = False
        ClearChanged_Resource()
        ClearResources()
        SendRequestResources()
    End Sub

#End Region

#Region "Skill Editor"

    Friend Sub SkillEditorInit()
        Dim i As Integer

        With frmEditor_Skill
            Editorindex = .lstIndex.SelectedIndex

            ' build class combo
            .cmbClass.Items.Clear()

           For i = 0 To MAX_JOBS
                .cmbClass.Items.Add(Trim$(Job(i).Name))
            Next
            .cmbClass.SelectedIndex = 0
            .cmbProjectile.Items.Clear()

           For i = 0 To MAX_PROJECTILES
                .cmbProjectile.Items.Add(Trim$(Projectile(i).Name))
            Next
            .cmbProjectile.SelectedIndex = 0

            .cmbAnimCast.Items.Clear()
            .cmbAnim.Items.Clear()

           For i = 0 To MAX_ANIMATIONS
                .cmbAnimCast.Items.Add(Trim$(Animation(i).Name))
                .cmbAnim.Items.Add(Trim$(Animation(i).Name))
            Next
            .cmbAnimCast.SelectedIndex = 0
            .cmbAnim.SelectedIndex = 0

            ' set values
            .txtName.Text = Trim$(Skill(Editorindex).Name)
            .cmbType.SelectedIndex = Skill(Editorindex).Type
            .nudMp.Value = Skill(Editorindex).MpCost
            .nudLevel.Value = Skill(Editorindex).LevelReq
            .cmbAccessReq.SelectedIndex = Skill(Editorindex).AccessReq
            .cmbClass.SelectedIndex = Skill(Editorindex).JobReq
            .nudCast.Value = Skill(Editorindex).CastTime
            .nudCool.Value = Skill(Editorindex).CdTime
            .nudIcon.Value = Skill(Editorindex).Icon
            .nudMap.Value = Skill(Editorindex).Map
            .nudX.Value = Skill(Editorindex).X
            .nudY.Value = Skill(Editorindex).Y
            .cmbDir.SelectedIndex = Skill(Editorindex).Dir
            .nudVital.Value = Skill(Editorindex).Vital
            .nudDuration.Value = Skill(Editorindex).Duration
            .nudInterval.Value = Skill(Editorindex).Interval
            .nudRange.Value = Skill(Editorindex).Range

            .chkAoE.Checked = Skill(Editorindex).IsAoE

            .nudAoE.Value = Skill(Editorindex).AoE
            .cmbAnimCast.SelectedIndex = Skill(Editorindex).CastAnim
            .cmbAnim.SelectedIndex = Skill(Editorindex).SkillAnim
            .nudStun.Value = Skill(Editorindex).StunDuration

            If Skill(Editorindex).IsProjectile = 1 Then
                .chkProjectile.Checked = True
            Else
                .chkProjectile.Checked = False
            End If
            .cmbProjectile.SelectedIndex = Skill(Editorindex).Projectile

            If Skill(Editorindex).KnockBack = 1 Then
                .chkKnockBack.Checked = True
            Else
                .chkKnockBack.Checked = False
            End If
            .cmbKnockBackTiles.SelectedIndex = Skill(Editorindex).KnockBackTiles
        End With

        EditorSkill_DrawIcon()
        Skill_Changed(Editorindex) = True
    End Sub

    Friend Sub SkillEditorOk()
        Dim i As Integer

       For i = 0 To MAX_SKILLS
            If Skill_Changed(i) Then
                SendSaveSkill(i)
            End If
        Next

        frmEditor_Skill.Visible = False
        Editor = -1
        ClearChanged_Skill()
    End Sub

    Friend Sub SkillEditorCancel()
        Editor = -1
        frmEditor_Skill.Visible = False
        ClearChanged_Skill()
        ClearSkills()
    End Sub

    Friend Sub ClearChanged_Skill()
       For i = 0 To MAX_SKILLS
            Skill_Changed(i) = False
        Next
    End Sub

#End Region

#Region "Shop editor"
    Friend Sub ShopEditorInit()
        Dim i As Integer

        Editorindex = frmEditor_Shop.lstIndex.SelectedIndex

        frmEditor_Shop.txtName.Text = Trim$(Shop(Editorindex).Name)
        If Shop(Editorindex).BuyRate > 0 Then
            frmEditor_Shop.nudBuy.Value = Shop(Editorindex).BuyRate
        Else
            frmEditor_Shop.nudBuy.Value = 100
        End If

        frmEditor_Shop.nudFace.Value = Shop(Editorindex).Face
        If File.Exists(Paths.Graphics & "Faces\" & Shop(Editorindex).Face & GfxExt) Then
            frmEditor_Shop.picFace.BackgroundImage = Drawing.Image.FromFile(Paths.Graphics & "Faces\" & Shop(Editorindex).Face & GfxExt)
        End If

        frmEditor_Shop.cmbItem.SelectedIndex = 0
        frmEditor_Shop.cmbCostItem.SelectedIndex = 0

        UpdateShopTrade()

        Shop_Changed(Editorindex) = True
    End Sub

    Friend Sub UpdateShopTrade()
        Dim i As Integer

        frmEditor_Shop.lstTradeItem.Items.Clear()

       For i = 0 To MAX_TRADES
            With Shop(Editorindex).TradeItem(i)
                ' if none, show as none
                If .Item = 0 AndAlso .CostItem = 0 Then
                    frmEditor_Shop.lstTradeItem.Items.Add("Empty Trade Slot")
                Else
                    frmEditor_Shop.lstTradeItem.Items.Add(i & ": " & .ItemValue & "x " & Trim$(Item(.Item).Name) & " for " & .CostValue & "x " & Trim$(Item(.CostItem).Name))
                End If
            End With
        Next

        frmEditor_Shop.lstTradeItem.SelectedIndex = 0
    End Sub

    Friend Sub ShopEditorOk()
        Dim i As Integer

       For i = 0 To MAX_SHOPS
            If Shop_Changed(i) Then
                SendSaveShop(i)
            End If
        Next

        frmEditor_Shop.Visible = False
        Editor = -1
        ClearChanged_Shop()
    End Sub

    Friend Sub ShopEditorCancel()
        Editor = -1
        frmEditor_Shop.Visible = False
        ClearChanged_Shop()
        ClearShops()
        SendRequestShops()
    End Sub

    Friend Sub ClearChanged_Shop()
       For i = 0 To MAX_SHOPS
            Shop_Changed(i) = False
        Next
    End Sub

#End Region

#Region "Job Editor"
    Friend Sub JobEditorOk()
        SendSaveJob()
        frmEditor_Job.Visible = False
        Editor = -1
    End Sub

    Friend Sub JobEditorCancel()
        Editor = -1
        frmEditor_Job.Visible = False
        SendRequestJobs()
    End Sub

    Friend Sub JobEditorInit()
        Dim i As Integer

        With frmEditor_Job
            Editorindex = .lstIndex.SelectedIndex

            .txtName.Text = Job(Editorindex).Name
            .txtDescription.Text = Job(Editorindex).Desc

            .nudMaleSprite.Value = Job(Editorindex).MaleSprite(0)
            .nudFemaleSprite.Value = Job(Editorindex).FemaleSprite(0)

            .cmbMaleSprite.SelectedIndex = 0
            .cmbFemaleSprite.SelectedIndex = 0

            .DrawPreview()

            For i = 0 To StatType.Count - 1
                If Job(Editorindex).Stat(i) = 0 Then Job(Editorindex).Stat(i) = 1
            Next

            .nudStrength.Value = Job(Editorindex).Stat(StatType.Strength)
            .nudLuck.Value = Job(Editorindex).Stat(StatType.Luck)
            .nudEndurance.Value = Job(Editorindex).Stat(StatType.Endurance)
            .nudIntelligence.Value = Job(Editorindex).Stat(StatType.Intelligence)
            .nudVitality.Value = Job(Editorindex).Stat(StatType.Vitality)
            .nudSpirit.Value = Job(Editorindex).Stat(StatType.Spirit)

            If Job(Editorindex).BaseExp < 00 Then
                .nudBaseExp.Value = 10
            Else
                .nudBaseExp.Value = Job(Editorindex).BaseExp
            End If

            .lstStartItems.Items.Clear()

           For i = 0 To MAX_DROP_ITEMS
                If Job(Editorindex).StartItem(i) > 0 Then
                    .lstStartItems.Items.Add(Item(Job(Editorindex).StartItem(i)).Name & " X " & Job(Editorindex).StartValue(i))
                End If
            Next

            .nudStartMap.Value = Job(Editorindex).StartMap
            .nudStartX.Value = Job(Editorindex).StartX
            .nudStartY.Value = Job(Editorindex).StartY
        End With
    End Sub

#End Region

#Region "Item"

    Friend Sub ItemEditorInit()
        Dim i As Integer

        Editorindex = frmEditor_Item.lstIndex.SelectedIndex

        With Item(Editorindex)
            frmEditor_Item.txtName.Text = Trim$(.Name)
            frmEditor_Item.txtDescription.Text = Trim$(.Description)

            If .Pic > frmEditor_Item.nudPic.Maximum Then .Pic = 0
            frmEditor_Item.nudPic.Value = .Pic
            If .Type > ItemType.Count - 1 Then .Type = 0
            frmEditor_Item.cmbType.SelectedIndex = .Type
            frmEditor_Item.cmbAnimation.SelectedIndex = .Animation

            If .ItemLevel = 0 Then .ItemLevel = 1
            frmEditor_Item.nudItemLvl.Value = .ItemLevel

            ' Type specific settings
            If (frmEditor_Item.cmbType.SelectedIndex = ItemType.Equipment) Then
                frmEditor_Item.fraEquipment.Visible = True
                frmEditor_Item.nudDamage.Value = .Data2
                frmEditor_Item.cmbTool.SelectedIndex = .Data3

                frmEditor_Item.cmbSubType.SelectedIndex = .SubType

                If .Speed < 1000 Then .Speed = 100
                If .Speed > frmEditor_Item.nudSpeed.Maximum Then .Speed = frmEditor_Item.nudSpeed.Maximum
                frmEditor_Item.nudSpeed.Value = .Speed

                frmEditor_Item.nudStrength.Value = .Add_Stat(StatType.Strength)
                frmEditor_Item.nudEndurance.Value = .Add_Stat(StatType.Endurance)
                frmEditor_Item.nudIntelligence.Value = .Add_Stat(StatType.Intelligence)
                frmEditor_Item.nudVitality.Value = .Add_Stat(StatType.Vitality)
                frmEditor_Item.nudLuck.Value = .Add_Stat(StatType.Luck)
                frmEditor_Item.nudSpirit.Value = .Add_Stat(StatType.Spirit)

                If .KnockBack = 1 Then
                    frmEditor_Item.chkKnockBack.Checked = True
                Else
                    frmEditor_Item.chkKnockBack.Checked = False
                End If
                frmEditor_Item.cmbKnockBackTiles.SelectedIndex = .KnockBackTiles

                If .Randomize = 1 Then
                    frmEditor_Item.chkRandomize.Checked = True
                Else
                    frmEditor_Item.chkRandomize.Checked = False
                End If

                frmEditor_Item.nudPaperdoll.Value = .Paperdoll

                If .SubType = EquipmentType.Weapon Then
                    frmEditor_Item.fraProjectile.Visible = True
                Else
                     frmEditor_Item.fraProjectile.Visible = False
                End If
            Else
                frmEditor_Item.fraEquipment.Visible = False
            End If

            If (frmEditor_Item.cmbType.SelectedIndex = ItemType.Consumable) Then
                frmEditor_Item.fraVitals.Visible = True
                frmEditor_Item.nudVitalMod.Value = .Data1
            Else
                frmEditor_Item.fraVitals.Visible = False
            End If

            If (frmEditor_Item.cmbType.SelectedIndex = ItemType.Skill) Then
                frmEditor_Item.fraSkill.Visible = True
                frmEditor_Item.cmbSkills.SelectedIndex = .Data1
            Else
                frmEditor_Item.fraSkill.Visible = False
            End If

            if (frmEditor_Item.cmbType.SelectedIndex = ItemType.Projectile) Then
                frmEditor_Item.fraProjectile.Visible = True
                frmEditor_Item.fraEquipment.Visible = True
            Elseif .Type <> ItemType.Equipment Then
                frmEditor_Item.fraProjectile.Visible = False
            End If

            If frmEditor_Item.cmbType.SelectedIndex = ItemType.CommonEvent Then
                frmEditor_Item.fraEvents.Visible = True
                frmEditor_Item.nudEvent.Value = .Data1
                frmEditor_Item.nudEventValue.Value = .Data2
            Else
                frmEditor_Item.fraEvents.Visible = False
            End If

            If frmEditor_Item.cmbType.SelectedIndex = ItemType.Furniture Then
                frmEditor_Item.fraFurniture.Visible = True
                If Item(Editorindex).Data2 > 0 AndAlso Item(Editorindex).Data2 <= NumFurniture Then
                    frmEditor_Item.nudFurniture.Value = Item(Editorindex).Data2
                Else
                    frmEditor_Item.nudFurniture.Value = 1
                End If
                frmEditor_Item.cmbFurnitureType.SelectedIndex = Item(Editorindex).Data1
            Else
                frmEditor_Item.fraFurniture.Visible = False
            End If

            If (frmEditor_Item.cmbType.SelectedIndex = ItemType.Pet) Then
                frmEditor_Item.fraPet.Visible = True
                frmEditor_Item.cmbPet.SelectedIndex = .Data1
            Else
                frmEditor_Item.fraPet.Visible = False
            End If

            ' Projectile
            frmEditor_Item.cmbProjectile.SelectedIndex = .Projectile
            frmEditor_Item.cmbAmmo.SelectedIndex = .Ammo

            ' Basic requirements
            frmEditor_Item.cmbAccessReq.SelectedIndex = .AccessReq
            frmEditor_Item.nudLevelReq.Value = .LevelReq

            frmEditor_Item.nudStrReq.Value = .Stat_Req(StatType.Strength)
            frmEditor_Item.nudVitReq.Value = .Stat_Req(StatType.Vitality)
            frmEditor_Item.nudLuckReq.Value = .Stat_Req(StatType.Luck)
            frmEditor_Item.nudEndReq.Value = .Stat_Req(StatType.Endurance)
            frmEditor_Item.nudIntReq.Value = .Stat_Req(StatType.Intelligence)
            frmEditor_Item.nudSprReq.Value = .Stat_Req(StatType.Spirit)

            ' Build cmbJobReq
            frmEditor_Item.cmbJobReq.Items.Clear()
           For i = 0 To MAX_JOBS
                frmEditor_Item.cmbJobReq.Items.Add(Job(i).Name)
            Next

            frmEditor_Item.cmbJobReq.SelectedIndex = .JobReq
            ' Info
            frmEditor_Item.nudPrice.Value = .Price
            frmEditor_Item.cmbBind.SelectedIndex = .BindType
            frmEditor_Item.nudRarity.Value = .Rarity

            If .Stackable = 1 Then
                frmEditor_Item.chkStackable.Checked = True
            Else
                frmEditor_Item.chkStackable.Checked = False
            End If
        End With

        EditorItem_DrawItem()
        EditorItem_DrawPaperdoll()
        EditorItem_DrawFurniture()
        Item_Changed(Editorindex) = True
    End Sub

    Friend Sub ItemEditorCancel()
        Editor = -1
        frmEditor_Item.Visible = False
        ClearChangedItem()
        ClearItems()
    End Sub

    Friend Sub ItemEditorOk()
        Dim i As Integer

       For i = 0 To MAX_ITEMS
            If Item_Changed(i) Then
                SendSaveItem(i)
            End If
        Next

        frmEditor_Item.Visible = False
        Editor = -1
        ClearChangedItem()
    End Sub

#End Region
End Module