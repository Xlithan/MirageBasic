Namespace Paths
    Public Module modPaths

        ''' <summary> Returns app directory </summary>
        Public ReadOnly Property Local As String
            Get
                Return AppDomain.CurrentDomain.BaseDirectory
            End Get
        End Property

        ''' <summary> Returns contents directory </summary>
        Public ReadOnly Property Contents As String
            Get
                Return AppDomain.CurrentDomain.BaseDirectory & "Contents\"
            End Get
        End Property

        ''' <summary> Returns database directory </summary>
        Public ReadOnly Property Database As String
            Get
                Return AppDomain.CurrentDomain.BaseDirectory & "Database\"
            End Get
        End Property

        ''' <summary> Returns configuration directory </summary>
        Public ReadOnly Property Config As String
            Get
                Return AppDomain.CurrentDomain.BaseDirectory & "Configuration\"
            End Get
        End Property

        '############################
        '###  Unique Directories  ###
        '############################

        ''' <summary> Returns graphics directory </summary>
        Public ReadOnly Property Graphics As String
            Get
                Return Contents & "\Graphics\"
            End Get
        End Property

        ''' <summary> Returns gui directory </summary>
        Public ReadOnly Property Gui As String
            Get
                Return Contents & "\Gui\"
            End Get
        End Property

        ''' <summary> Returns music directory </summary>
        Public ReadOnly Property Music As String
            Get
                Return Contents & "\Music\"
            End Get
        End Property

        ''' <summary> Returns sounds directory </summary>
        Public ReadOnly Property Sounds As String
            Get
                Return Contents & "\Sounds\"
            End Get
        End Property

        ''' <summary> Returns accounts directory <\summary>
        Public ReadOnly Property Accounts As String
            Get
                Return AppDomain.CurrentDomain.BaseDirectory & "\Database\Accounts\"
            End Get
        End Property

        ''' <summary> Returns account file <\summary>
        Public Function Account(index As Integer) As String
            Return Accounts & index & ".dat"
        End Function

        ''' <summary> Returns animations directory <\summary>
        Public ReadOnly Property Animations As String
            Get
                Return AppDomain.CurrentDomain.BaseDirectory & "\Database\Animations\"
            End Get
        End Property

        ''' <summary> Returns animation file <\summary>
        Public Function Animation(index As Integer) As String
            Return Animations & index & ".dat"
        End Function

        ''' <summary> Returns items directory <\summary>
        Public ReadOnly Property Items As String
            Get
                Return AppDomain.CurrentDomain.BaseDirectory & "\Database\Items\"
            End Get
        End Property

        ''' <summary> Returns item file <\summary>
        Public Function Item(index As Integer) As String
            Return Items & index & ".dat"
        End Function

        ''' <summary> Returns logs directory <\summary>
        Public ReadOnly Property Logs As String
            Get
                Return AppDomain.CurrentDomain.BaseDirectory & "\Logs\"
            End Get
        End Property

        ''' <summary> Returns maps directory <\summary>
        Public ReadOnly Property Maps As String
            Get
                Return AppDomain.CurrentDomain.BaseDirectory & "\Database\Maps\"
            End Get
        End Property

         ''' <summary> Returns map file <\summary>
        Public Function Map(index As Integer) As String
            Return Maps & index & ".dat"
        End Function

         ''' <summary> Returns map file <\summary>
        Public Function EventMap(index As Integer) As String
            Return Maps & index & "_event.dat"
        End Function

        ''' <summary> Returns npcs directory <\summary>
        Public ReadOnly Property Npcs As String
            Get
                Return AppDomain.CurrentDomain.BaseDirectory & "\Database\Npcs\"
            End Get
        End Property

        ''' <summary> Returns npc file <\summary>
        Public Function Npc(index As Integer) As String
            Return Npcs() & index & ".dat"
        End Function

        ''' <summary> Returns pets directory <\summary>
        Public ReadOnly Property Pets As String
            Get
                Return AppDomain.CurrentDomain.BaseDirectory & "\Database\Pets\"
            End Get
        End Property

        ''' <summary> Returns pet file <\summary>
        Public Function Pet(index As Integer) As String
            Return Pets() & index & ".dat"
        End Function

        ''' <summary> Returns projectiles directory <\summary>
        Public ReadOnly Property Projectiles As String
            Get
                Return AppDomain.CurrentDomain.BaseDirectory & "\Database\Projectiles\"
            End Get
        End Property

        ''' <summary> Returns projectile file <\summary>
        Public Function Projectile(index As Integer) As String
            Return Projectiles() & index & ".dat"
        End Function

        ''' <summary> Returns quests directory <\summary>
        Public ReadOnly Property Quests As String
            Get
                Return AppDomain.CurrentDomain.BaseDirectory & "\Database\Quests\"
            End Get
        End Property

        ''' <summary> Returns quest file <\summary>
        Public Function Quest(index As Integer) As String
            Return Quests() & index & ".dat"
        End Function

        ''' <summary> Returns recipes directory <\summary>
        Public ReadOnly Property Recipes As String
            Get
                Return AppDomain.CurrentDomain.BaseDirectory & "\Database\Recipes\"
            End Get
        End Property

        ''' <summary> Returns recipe file <\summary>
        Public Function Recipe(index As Integer) As String
            Return Recipes() & index & ".dat"
        End Function

        ''' <summary> Returns resources directory <\summary>
        Public ReadOnly Property Resources As String
            Get
                Return AppDomain.CurrentDomain.BaseDirectory & "\Database\Resources\"
            End Get
        End Property

        ''' <summary> Returns resource file <\summary>
        Public Function Resource(index As Integer) As String
            Return Resources() & index & ".dat"
        End Function

        ''' <summary> Returns shops directory <\summary>
        Public ReadOnly Property Shops As String
            Get
                Return AppDomain.CurrentDomain.BaseDirectory & "\Database\Shops\"
            End Get
        End Property

        ''' <summary> Returns shop file <\summary>
        Public Function Shop(index As Integer) As String
            Return Shops() & index & ".dat"
        End Function

        ''' <summary> Returns skills directory <\summary>
        Public ReadOnly Property Skills As String
            Get
                Return AppDomain.CurrentDomain.BaseDirectory & "\Database\Skills\"
            End Get
        End Property

        ''' <summary> Returns skill file </summary>
        Public Function Skill(index As Integer) As String
            Return Skills() & index & ".dat"
        End Function
    End Module
End Namespace