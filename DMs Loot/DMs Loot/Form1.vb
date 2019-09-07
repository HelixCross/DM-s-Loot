Public Class Form1
    Dim x, y As Integer ' assings the 2d points for the mouse and the form.
    Dim newpoint As Point 'the newpoint is the dimantion that it will assing the position of the application

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LinkLabel1.Text = ("Magic Item Compendium.")
        LinkLabel1.Links.Add(0, 22, "https://dtdnd.neocities.org/books/player/Magic%20Item%20Compendium.pdf")

        LinkLabel2.Text = ("Dungeon Master's Guide.")
        LinkLabel2.Links.Add(0, 23, "http://forum.nwnights.ru/uploads/rulebooks/Core_Books/Dungeon_Master's_Guide.pdf")

        LinkLabel3.Text = ("Weapons Of Legacy.")
        LinkLabel3.Links.Add(0, 17, "http://choisey.free.fr/3.5/Help/Weapons%20of%20Legacy.pdf")

        LinkLabel4.Text = ("Arms And Equipment Guide.")
        LinkLabel4.Links.Add(0, 25, "https://www.scribd.com/document/6105229/arms-and-equipment-guide")

        LinkLabel5.Text = ("Forgotten Realms.")
        LinkLabel5.Links.Add(0, 18, "https://www.scribd.com/doc/177487154/D-D-3-5-Forgotten-Realms-Campaign-Setting")

        LinkLabel6.Text = ("Forgotten Realms-Races Of Faerûn.")
        LinkLabel6.Links.Add(0, 33, "http://www.mpsw.hu/files/dand_35/D&D%203.5%20-%20Races%20of%20Faerun%20%5BOEF%5D.pdf")

        LinkLabel7.Text = ("Forgotten Realms-Power Of Faerûn.")
        LinkLabel7.Links.Add(0, 34, "https://www.scribd.com/document/117644679/Forgotten-Realms-D-D-3-5-Power-of-Faerun")

        LinkLabel8.Text = ("Dieties And Demigods Of Faerûn.")
        LinkLabel8.Links.Add(0, 30, "http://home.nitkin.net/dndbooks/DaD_DietiesAndDemigods.pdf")

        LinkLabel9.Text = ("Monster Manual.")
        LinkLabel9.Links.Add(0, 15, "http://forum.nwnights.ru/uploads/rulebooks/Core_Books/Monster_Manual.pdf")

        LinkLabel10.Text = ("Monsters Of Faerûn.")
        LinkLabel10.Links.Add(0, 20, "http://files.full-hyperion.nl/dnd/Monsters%20of%20Faerun.pdf")

        LinkLabel11.Text = ("Monster Manual 2.")
        LinkLabel11.Links.Add(0, 20, "http://choisey.free.fr/3.5/Core/Dungeons%20and%20Dragons%203.5%20-%20Monster%20Manual%20II.pdf")



    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown ' In this event the same point is assinged for the forms location and the mouse location
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y

    End Sub



    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove 'By calling the windows forms mouse buttons we get the cotrol position to be connected with the appplication events.
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()

        End If
    End Sub



    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover

    End Sub



    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover


        Label1.Text = "The Item list from this level range will have many basic items and one or two +1 items"

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Label1.Text = ""
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        Label1.Text = "The loot list will have some +2 items and more +1 Items to roll from."
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Label1.Text = ""
    End Sub

    Private Sub Button4_MouseHover(sender As Object, e As EventArgs) Handles Button4.MouseHover
        Label1.Text = "This list will generate items +2 mostly and a few +3 items."
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Label1.Text = ""
    End Sub

    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles Button5.MouseHover
        Label1.Text = "It will generate a list for 50-50% chances items of +2 and +3 enchantments."
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Label1.Text = ""
    End Sub

    Private Sub Button6_MouseHover(sender As Object, e As EventArgs) Handles Button6.MouseHover
        Label1.Text = "Lists items with the majority of them at +3 and having some +4."
    End Sub

    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs) Handles Button6.MouseLeave
        Label1.Text = ""
    End Sub

    Private Sub Button7_MouseHover(sender As Object, e As EventArgs) Handles Button7.MouseHover
        Label1.Text = "With this list, the drops will range from +4 and a few ones ate +5."
    End Sub

    Private Sub Button7_MouseLeave(sender As Object, e As EventArgs) Handles Button7.MouseLeave
        Label1.Text = ""
    End Sub

    Private Sub Button8_MouseHover(sender As Object, e As EventArgs) Handles Button8.MouseHover
        Label1.Text = "The item list will generate items with 50-50% chances items from +4 and +5."
    End Sub

    Private Sub Button8_MouseLeave(sender As Object, e As EventArgs) Handles Button8.MouseLeave
        Label1.Text = ""
    End Sub

    Private Sub Button9_MouseHover(sender As Object, e As EventArgs) Handles Button9.MouseHover
        Label1.Text = "This list has relic, artefacts, and legacy Items. These are powerfull Items and they need an experianced DM."
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "1" Then
            TextBox3.Text = "Dagger"
        ElseIf TextBox1.Text = "2" Then
            TextBox3.Text = "Scythe"
        ElseIf TextBox1.Text = "3" Then
            TextBox3.Text = "GreatAxe"
        ElseIf TextBox1.Text = "4" Then
            TextBox3.Text = "Rusted Rapier"
        ElseIf TextBox1.Text = "5" Then
            TextBox3.Text = "Scimitar"
        ElseIf TextBox1.Text = "6" Then
            TextBox3.Text = "Damaged Dagger"
        ElseIf TextBox1.Text = "7" Then
            TextBox3.Text = "Longsword"
        ElseIf TextBox1.Text = "8" Then
            TextBox3.Text = "Slightly Damaged Scimitar"
        ElseIf TextBox1.Text = "9" Then
            TextBox3.Text = "Badly Damaged Greatsword "
        ElseIf TextBox1.Text = "10" Then
            TextBox3.Text = "Longbow"
        ElseIf TextBox1.Text = "11" Then
            TextBox3.Text = "Shortsword"
        ElseIf TextBox1.Text = "12" Then
            TextBox3.Text = "Flail"
        ElseIf TextBox1.Text = "13" Then
            TextBox3.Text = "Double Orc Axe"
        ElseIf TextBox1.Text = "14" Then
            TextBox3.Text = " Rapier"
        ElseIf TextBox1.Text = "15" Then
            TextBox3.Text = "Damaged Scimitar"
        ElseIf TextBox1.Text = "16" Then
            TextBox3.Text = "Masterwork Dagger"
        ElseIf TextBox1.Text = "17" Then
            TextBox3.Text = "Heavy Flail"
        ElseIf TextBox1.Text = "18" Then
            TextBox3.Text = "Light Mace"
        ElseIf TextBox1.Text = "19" Then
            TextBox3.Text = "Light Crossbow "
        ElseIf TextBox1.Text = "20" Then
            TextBox3.Text = "Damaged Whip"
        ElseIf TextBox1.Text = "21" Then
            TextBox3.Text = "Masterwork Longbow"
        ElseIf TextBox1.Text = "22" Then
            TextBox3.Text = "Heavy Crossbow"
        ElseIf TextBox1.Text = "23" Then
            TextBox3.Text = "Heavy Mace"
        ElseIf TextBox1.Text = "24" Then
            TextBox3.Text = "Double Bladed Sword"
        ElseIf TextBox1.Text = "25" Then
            TextBox3.Text = " Bastardsword"
        ElseIf TextBox1.Text = "26" Then
            TextBox3.Text = "20 Crossbow Bolts"
        ElseIf TextBox1.Text = "27" Then
            TextBox3.Text = "+1 Dagger"
        ElseIf TextBox1.Text = "28" Then
            TextBox3.Text = "Leather Armour"
        ElseIf TextBox1.Text = "29" Then
            TextBox3.Text = "20 Bow Arrows"
        ElseIf TextBox1.Text = "30" Then
            TextBox3.Text = "Masterwork Rapier "
        ElseIf TextBox1.Text = "31" Then
            TextBox3.Text = "warhammer"
        ElseIf TextBox1.Text = "32" Then
            TextBox3.Text = "+1 Greatsword"
        ElseIf TextBox1.Text = "33" Then
            TextBox3.Text = "Staff"
        ElseIf TextBox1.Text = "34" Then
            TextBox3.Text = "Masterwork Light Crossbow"
        ElseIf TextBox1.Text = "35" Then
            TextBox3.Text = "Damaged Longbow"
        ElseIf TextBox1.Text = "36" Then
            TextBox3.Text = "Chainmail"
        ElseIf TextBox1.Text = "37" Then
            TextBox3.Text = "Kopesh"
        ElseIf TextBox1.Text = "38" Then
            TextBox3.Text = "Breastplate"
        ElseIf TextBox1.Text = "39" Then
            TextBox3.Text = "Pick "
        ElseIf TextBox1.Text = "40" Then
            TextBox3.Text = "Light pick"
        ElseIf TextBox1.Text = "41" Then
            TextBox3.Text = "Full Plate"
        ElseIf TextBox1.Text = "42" Then
            TextBox3.Text = "Spear"
        ElseIf TextBox1.Text = "43" Then
            TextBox3.Text = "Javeling"
        ElseIf TextBox1.Text = "44" Then
            TextBox3.Text = "Falchion"
        ElseIf TextBox1.Text = "45" Then
            TextBox3.Text = "Slightly Damaged Fullplate"
        ElseIf TextBox1.Text = "46" Then
            TextBox3.Text = "Slingshot"
        ElseIf TextBox1.Text = "47" Then
            TextBox3.Text = "Suriken"
        ElseIf TextBox1.Text = "48" Then
            TextBox3.Text = "Throwing Dagger"
        ElseIf TextBox1.Text = "49" Then
            TextBox3.Text = "Dwarven Waraxe"
        ElseIf TextBox1.Text = "50" Then
            TextBox3.Text = "Buckler"
        ElseIf TextBox1.Text = "51" Then
            TextBox3.Text = "Thives Tools"
        ElseIf TextBox1.Text = "52" Then
            TextBox3.Text = "Reapiting Light Crossbow"
        ElseIf TextBox1.Text = "53" Then
            TextBox3.Text = "Badly Damaged Kopesh"
        ElseIf TextBox1.Text = "54" Then
            TextBox3.Text = "Heavily Rusted Halfplate"
        ElseIf TextBox1.Text = "55" Then
            TextBox3.Text = "Halbert"
        ElseIf TextBox1.Text = "56" Then
            TextBox3.Text = "Halfplate"
        ElseIf TextBox1.Text = "57" Then
            TextBox3.Text = "Studded Leather"
        ElseIf TextBox1.Text = "58" Then
            TextBox3.Text = "Potion Belt"
        ElseIf TextBox1.Text = "59" Then
            TextBox3.Text = "20 Masterwork Arrows"
        ElseIf TextBox1.Text = "60" Then
            TextBox3.Text = "Chackram"
        ElseIf TextBox1.Text = "61" Then
            TextBox3.Text = "20 Masterwork bolts"
        ElseIf TextBox1.Text = "62" Then
            TextBox3.Text = "Rusted longsword"
        ElseIf TextBox1.Text = "63" Then
            TextBox3.Text = "Spiked Chain"
        ElseIf TextBox1.Text = "64" Then
            TextBox3.Text = "Razorblade Net"
        ElseIf TextBox1.Text = "65" Then
            TextBox3.Text = "Morningstar"
        ElseIf TextBox1.Text = "66" Then
            TextBox3.Text = "Repeating Heavy Crossbow"
        ElseIf TextBox1.Text = "67" Then
            TextBox3.Text = "Aid Kit"
        ElseIf TextBox1.Text = "68" Then
            TextBox3.Text = "Dwarven Urgrosh"
        ElseIf TextBox1.Text = "69" Then
            TextBox3.Text = "Matserwork Light Shield"
        ElseIf TextBox1.Text = "70" Then
            TextBox3.Text = "Heavy Shield"
        ElseIf TextBox1.Text = "71" Then
            TextBox3.Text = "Cure Light Wounds Potion"
        ElseIf TextBox1.Text = "72" Then
            TextBox3.Text = "Alchemist's Sleeping Potion"
        ElseIf TextBox1.Text = "73" Then
            TextBox3.Text = "+1 Scimitar"
        ElseIf TextBox1.Text = "74" Then
            TextBox3.Text = "Masterwork Thives Tools"
        ElseIf TextBox1.Text = "75" Then
            TextBox3.Text = "Blade Boots"
        ElseIf TextBox1.Text = "76" Then
            TextBox3.Text = "Matserwork Doudle Orc Axe"
        ElseIf TextBox1.Text = "77" Then
            TextBox3.Text = "Battle Axe"
        ElseIf TextBox1.Text = "78" Then
            TextBox3.Text = "Hand Axe"
        ElseIf TextBox1.Text = "79" Then
            TextBox3.Text = "A Pouch Of 524 GP"
        ElseIf TextBox1.Text = "80" Then
            TextBox3.Text = "Sickle"
        ElseIf TextBox1.Text = "81" Then
            TextBox3.Text = "Kama"
        ElseIf TextBox1.Text = "82" Then
            TextBox3.Text = "Club"
        ElseIf TextBox1.Text = "83" Then
            TextBox3.Text = "Kukri"
        ElseIf TextBox1.Text = "84" Then
            TextBox3.Text = "Sap (Blackjack)"
        ElseIf TextBox1.Text = "85" Then
            TextBox3.Text = "Spiked Armour"
        ElseIf TextBox1.Text = "86" Then
            TextBox3.Text = "Spiked Shield"
        ElseIf TextBox1.Text = "87" Then
            TextBox3.Text = "Lance"
        ElseIf TextBox1.Text = "88" Then
            TextBox3.Text = "Nuchaku"
        ElseIf TextBox1.Text = "89" Then
            TextBox3.Text = "Sai"
        ElseIf TextBox1.Text = "90" Then
            TextBox3.Text = "Composite Longbow"
        ElseIf TextBox1.Text = "91" Then
            TextBox3.Text = "Dire Flail"
        ElseIf TextBox1.Text = "92" Then
            TextBox3.Text = "Hand Crossbow"
        ElseIf TextBox1.Text = "93" Then
            TextBox3.Text = "Bolas"
        ElseIf TextBox1.Text = "94" Then
            TextBox3.Text = "Double Gnome Blade"
        ElseIf TextBox1.Text = "95" Then
            TextBox3.Text = "Trident"
        ElseIf TextBox1.Text = "96" Then
            TextBox3.Text = "Glaive"
        ElseIf TextBox1.Text = "97" Then
            TextBox3.Text = "Short Spear"
        ElseIf TextBox1.Text = "98" Then
            TextBox3.Text = "Rusted Trident"
        ElseIf TextBox1.Text = "99" Then
            TextBox3.Text = "Net"
        ElseIf TextBox1.Text = "100" Then
            TextBox3.Text = "Masterwork Greataxe"

        End If




    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            TextBox3.Text = ""
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button9_MouseLeave(sender As Object, e As EventArgs) Handles Button9.MouseLeave
        Label1.Text = ""
    End Sub

    Private Sub RichTextBox1_MouseHover(sender As Object, e As EventArgs) Handles RichTextBox1.MouseHover
        Label1.Text = "In this TextBox you can paste the item that you rolled for a player from the Item Drop Field."
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "1" Then
            TextBox3.Text = "Crue Moderate Wounds"
        ElseIf TextBox1.Text = "2" Then
            TextBox3.Text = " +1 Frost Scythe"
        ElseIf TextBox1.Text = "3" Then
            TextBox3.Text = "+1 Keen Dagger"
        ElseIf TextBox1.Text = "4" Then
            TextBox3.Text = "Combosite Longbow of Ghoul Touch"
        ElseIf TextBox1.Text = "5" Then
            TextBox3.Text = "+1 Fullplate"
        ElseIf TextBox1.Text = "6" Then
            TextBox3.Text = "+1 Breastplate"
        ElseIf TextBox1.Text = "7" Then
            TextBox3.Text = "Mithril Ore"
        ElseIf TextBox1.Text = "8" Then
            TextBox3.Text = "Pouch Of 856 PP"
        ElseIf TextBox1.Text = "9" Then
            TextBox3.Text = "Mudbane Club "
        ElseIf TextBox1.Text = "10" Then
            TextBox3.Text = "+1 Scimitar of Flaming Burst"
        ElseIf TextBox1.Text = "11" Then
            TextBox3.Text = "+1 Acid Shortsword"
        ElseIf TextBox1.Text = "12" Then
            TextBox3.Text = "Shortbow Of Harmsting"
        ElseIf TextBox1.Text = "13" Then
            TextBox3.Text = "+1 Adamantine Dwarven Waraxe "
        ElseIf TextBox1.Text = "14" Then
            TextBox3.Text = "+1 Zombiebane light hammer"
        ElseIf TextBox1.Text = "15" Then
            TextBox3.Text = "Sling With Bullets 20 pts"
        ElseIf TextBox1.Text = "16" Then
            TextBox3.Text = "+1 Anarchic Greataxe"
        ElseIf TextBox1.Text = "17" Then
            TextBox3.Text = "Mithril Light Shield"
        ElseIf TextBox1.Text = "18" Then
            TextBox3.Text = "Heavy Shield of Lesser Flame Guard"
        ElseIf TextBox1.Text = "19" Then
            TextBox3.Text = "+1 Sonic Flail"
        ElseIf TextBox1.Text = "20" Then
            TextBox3.Text = "+1 Charesmatic Clock"
        ElseIf TextBox1.Text = "21" Then
            TextBox3.Text = "+1 Shock Longbow"
        ElseIf TextBox1.Text = "22" Then
            TextBox3.Text = "Damaged Greatebow"
        ElseIf TextBox1.Text = "23" Then
            TextBox3.Text = "20 +1 Masterwork bolts"
        ElseIf TextBox1.Text = "24" Then
            TextBox3.Text = "Alchemist's Fire"
        ElseIf TextBox1.Text = "25" Then
            TextBox3.Text = "Lock Gaunlet"
        ElseIf TextBox1.Text = "26" Then
            TextBox3.Text = "10 +2 Crossbow Bolts"
        ElseIf TextBox1.Text = "27" Then
            TextBox3.Text = "Scale Mail Armour"
        ElseIf TextBox1.Text = "28" Then
            TextBox3.Text = "+2 TowerShield of Lesser Shock Guard"
        ElseIf TextBox1.Text = "29" Then
            TextBox3.Text = "+1 Returning Throwing Dagger"
        ElseIf TextBox1.Text = "30" Then
            TextBox3.Text = "Scroll of Sonic Protection "
        ElseIf TextBox1.Text = "31" Then
            TextBox3.Text = "+1 Dwarven Urgorsh"
        ElseIf TextBox1.Text = "32" Then
            TextBox3.Text = "+1 Greatsword Of Maim"
        ElseIf TextBox1.Text = "33" Then
            TextBox3.Text = "+1 Longsword Of Vertigo"
        ElseIf TextBox1.Text = "34" Then
            TextBox3.Text = "Scroll of Magic Missiles"
        ElseIf TextBox1.Text = "35" Then
            TextBox3.Text = "Raw Saphire Fragment"
        ElseIf TextBox1.Text = "36" Then
            TextBox3.Text = "+1 Flame Kopesh"
        ElseIf TextBox1.Text = "37" Then
            TextBox3.Text = "Masterwork Scale Mail"
        ElseIf TextBox1.Text = "38" Then
            TextBox3.Text = "+1 Ogre Power Gloves"
        ElseIf TextBox1.Text = "39" Then
            TextBox3.Text = "+1 Wise Ring Of Eagle"
        ElseIf TextBox1.Text = "40" Then
            TextBox3.Text = "Fox Cunning Ring"
        ElseIf TextBox1.Text = "41" Then
            TextBox3.Text = "Expedious Retreat Neckless"
        ElseIf TextBox1.Text = "42" Then
            TextBox3.Text = "+1 Wise Neckless"
        ElseIf TextBox1.Text = "43" Then
            TextBox3.Text = "+1 Cunning ring Of Listening"
        ElseIf TextBox1.Text = "44" Then
            TextBox3.Text = "+1 Shortsword"
        ElseIf TextBox1.Text = "45" Then
            TextBox3.Text = "+1 Buckler Of Frost Guard"
        ElseIf TextBox1.Text = "46" Then
            TextBox3.Text = "Boots Of Swimming"
        ElseIf TextBox1.Text = "47" Then
            TextBox3.Text = "+1 Dexterous Ring"
        ElseIf TextBox1.Text = "48" Then
            TextBox3.Text = "+1 Belt Of Lesser False Life"
        ElseIf TextBox1.Text = "49" Then
            TextBox3.Text = "+1 Belt of Endurance"
        ElseIf TextBox1.Text = "50" Then
            TextBox3.Text = "+1 Maiming Whip"
        ElseIf TextBox1.Text = "51" Then
            TextBox3.Text = "Scroll Of Fox Cunning"
        ElseIf TextBox1.Text = "52" Then
            TextBox3.Text = "Scroll Of Charm Person"
        ElseIf TextBox1.Text = "53" Then
            TextBox3.Text = "+1 Spearblock Braces"
        ElseIf TextBox1.Text = "54" Then
            TextBox3.Text = "Boots Of Move Silently"
        ElseIf TextBox1.Text = "55" Then
            TextBox3.Text = "Diamond Dust"
        ElseIf TextBox1.Text = "56" Then
            TextBox3.Text = "+1 Chainmail"
        ElseIf TextBox1.Text = "57" Then
            TextBox3.Text = "+1 Boots Of Protection"
        ElseIf TextBox1.Text = "58" Then
            TextBox3.Text = "+1 Swordblock Braces"
        ElseIf TextBox1.Text = "59" Then
            TextBox3.Text = "+1 Greatsword"
        ElseIf TextBox1.Text = "60" Then
            TextBox3.Text = "+1 Chaotic Rapier"
        ElseIf TextBox1.Text = "61" Then
            TextBox3.Text = "+1 5 Masterwork bolts"
        ElseIf TextBox1.Text = "62" Then
            TextBox3.Text = "+1 Axiomatic Longsword"
        ElseIf TextBox1.Text = "63" Then
            TextBox3.Text = "Quest Item"
        ElseIf TextBox1.Text = "64" Then
            TextBox3.Text = "+1 Spiked Shield"
        ElseIf TextBox1.Text = "65" Then
            TextBox3.Text = "+1 Morningstar Of Lesser Poison"
        ElseIf TextBox1.Text = "66" Then
            TextBox3.Text = "+2 Holy Grate Bow"
        ElseIf TextBox1.Text = "67" Then
            TextBox3.Text = "Masterwork Aid Kit"
        ElseIf TextBox1.Text = "68" Then
            TextBox3.Text = "+1 Gloves Of Slight Of Hands"
        ElseIf TextBox1.Text = "69" Then
            TextBox3.Text = "Fire Trap Schematics"
        ElseIf TextBox1.Text = "70" Then
            TextBox3.Text = "+1 Falchion Of Lesser Curse Spewing"
        ElseIf TextBox1.Text = "71" Then
            TextBox3.Text = "Cure Poison Potion"
        ElseIf TextBox1.Text = "72" Then
            TextBox3.Text = "Bulls Strenght Potion"
        ElseIf TextBox1.Text = "73" Then
            TextBox3.Text = "Cure Disease Potion"
        ElseIf TextBox1.Text = "74" Then
            TextBox3.Text = "Potion Of Invisibillity"
        ElseIf TextBox1.Text = "75" Then
            TextBox3.Text = "Ring Of Underwater Breathing"
        ElseIf TextBox1.Text = "76" Then
            TextBox3.Text = "Feather Falling belt"
        ElseIf TextBox1.Text = "77" Then
            TextBox3.Text = "Cats Grace Potion"
        ElseIf TextBox1.Text = "78" Then
            TextBox3.Text = "+1 Adamantine Hand Axe"
        ElseIf TextBox1.Text = "79" Then
            TextBox3.Text = "+1 Acid Longbow"
        ElseIf TextBox1.Text = "80" Then
            TextBox3.Text = "Ring Of Mage Armour"
        ElseIf TextBox1.Text = "81" Then
            TextBox3.Text = "+1 Wounding Kama"
        ElseIf TextBox1.Text = "82" Then
            TextBox3.Text = "+2 Unholy Bastardsword"
        ElseIf TextBox1.Text = "83" Then
            TextBox3.Text = "+2 Keen Double Orc Axe"
        ElseIf TextBox1.Text = "84" Then
            TextBox3.Text = "+1 Warhammer"
        ElseIf TextBox1.Text = "85" Then
            TextBox3.Text = "+1 Boots Of Hiding"
        ElseIf TextBox1.Text = "86" Then
            TextBox3.Text = "Scroll Of Jump"
        ElseIf TextBox1.Text = "87" Then
            TextBox3.Text = "Reincforced Eleven Rope"
        ElseIf TextBox1.Text = "88" Then
            TextBox3.Text = "+1 12 Frost Surikens"
        ElseIf TextBox1.Text = "89" Then
            TextBox3.Text = "+1 Lizardfolk Bane Lance"
        ElseIf TextBox1.Text = "90" Then
            TextBox3.Text = "+1 Force Composite Longbow"
        ElseIf TextBox1.Text = "91" Then
            TextBox3.Text = "+1 Human Bane Dire Flail"
        ElseIf TextBox1.Text = "92" Then
            TextBox3.Text = "+1 Dragon Bane Hand Crossbow"
        ElseIf TextBox1.Text = "93" Then
            TextBox3.Text = "+1 Double Blade Sword "
        ElseIf TextBox1.Text = "94" Then
            TextBox3.Text = "+1 Frost pick"
        ElseIf TextBox1.Text = "95" Then
            TextBox3.Text = "+1 Flaming Trident"
        ElseIf TextBox1.Text = "96" Then
            TextBox3.Text = "Frost Touche Glaive +1 Frost Damage"
        ElseIf TextBox1.Text = "97" Then
            TextBox3.Text = "Remove Curse Potion"
        ElseIf TextBox1.Text = "98" Then
            TextBox3.Text = "+1 Wouding Kopesh"
        ElseIf TextBox1.Text = "99" Then
            TextBox3.Text = "Spider Venom Vial - 10 charges "
        ElseIf TextBox1.Text = "100" Then
            TextBox3.Text = "+2 Frost Burst Gratesword Of Frost Maiming "

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "1" Then
            TextBox3.Text = "+2 Draksteel Longsword"
        ElseIf TextBox1.Text = "2" Then
            TextBox3.Text = " +2 Keen Frost Scythe"
        ElseIf TextBox1.Text = "3" Then
            TextBox3.Text = "+3 Keen Shock Shocking Greataxe "
        ElseIf TextBox1.Text = "4" Then
            TextBox3.Text = "+2 Holy GreatBow "
        ElseIf TextBox1.Text = "5" Then
            TextBox3.Text = "+2 Fullplate Of Lesser Force Guard"
        ElseIf TextBox1.Text = "6" Then
            TextBox3.Text = "+2 Mithril Chain Shirt"
        ElseIf TextBox1.Text = "7" Then
            TextBox3.Text = "+2 Axiomatic Longsword Of Vertigo"
        ElseIf TextBox1.Text = "8" Then
            TextBox3.Text = "+2 Thives Tools"
        ElseIf TextBox1.Text = "9" Then
            TextBox3.Text = "+2 Charismatic Ring"
        ElseIf TextBox1.Text = "10" Then
            TextBox3.Text = "Troll Regeneration Ring"
        ElseIf TextBox1.Text = "11" Then
            TextBox3.Text = "Scroll Of Call Lightning"
        ElseIf TextBox1.Text = "12" Then
            TextBox3.Text = "+2 Sai"
        ElseIf TextBox1.Text = "13" Then
            TextBox3.Text = "+2 Adamantine FullPlate Of Lesser Frotification "
        ElseIf TextBox1.Text = "14" Then
            TextBox3.Text = "+2 FullPlate Of Deathblock "
        ElseIf TextBox1.Text = "15" Then
            TextBox3.Text = "+3 Fearsome Greatsword Of Sonic Burst"
        ElseIf TextBox1.Text = "16" Then
            TextBox3.Text = "+2 Helmet Of True Sight"
        ElseIf TextBox1.Text = "17" Then
            TextBox3.Text = "+2 Towershield Of Acid Guard"
        ElseIf TextBox1.Text = "18" Then
            TextBox3.Text = "+2 Ring of Climbing"
        ElseIf TextBox1.Text = "19" Then
            TextBox3.Text = "+2 Cunning Neckless Of Spell Penetration (2) "
        ElseIf TextBox1.Text = "20" Then
            TextBox3.Text = "+2 Charesmatic Cloack"
        ElseIf TextBox1.Text = "21" Then
            TextBox3.Text = "+2 Neckless Of Indimitation"
        ElseIf TextBox1.Text = "22" Then
            TextBox3.Text = "Potion Of Eagle Splendor"
        ElseIf TextBox1.Text = "23" Then
            TextBox3.Text = "+2 Staff Of Spell Resistance"
        ElseIf TextBox1.Text = "24" Then
            TextBox3.Text = "Tresure Map"
        ElseIf TextBox1.Text = "25" Then
            TextBox3.Text = "+2 Giant Bane Dwarven Waraxe"
        ElseIf TextBox1.Text = "26" Then
            TextBox3.Text = "+2 Bracers Od Natural Armour"
        ElseIf TextBox1.Text = "27" Then
            TextBox3.Text = "Ring of Pass Without Trace"
        ElseIf TextBox1.Text = "28" Then
            TextBox3.Text = "2+ Belt Of Endurance"
        ElseIf TextBox1.Text = "29" Then
            TextBox3.Text = "+2 Keen Flaming Kukri Of Maiming"
        ElseIf TextBox1.Text = "30" Then
            TextBox3.Text = "+2 Cloack Of Sonic Resistance"
        ElseIf TextBox1.Text = "31" Then
            TextBox3.Text = "+2 Swift Boots Of Featherfalling"
        ElseIf TextBox1.Text = "32" Then
            TextBox3.Text = "+2 Backstabbers Gloves Of Move Silently"
        ElseIf TextBox1.Text = "33" Then
            TextBox3.Text = "2+ Neckless Of Bluff"
        ElseIf TextBox1.Text = "34" Then
            TextBox3.Text = "Ring Of Glitterdust"
        ElseIf TextBox1.Text = "35" Then
            TextBox3.Text = "Dragon Scale"
        ElseIf TextBox1.Text = "36" Then
            TextBox3.Text = "+2 Flame Kopesh Of Force Busrt"
        ElseIf TextBox1.Text = "37" Then
            TextBox3.Text = "+2 Scale Mail Of Swimming "
        ElseIf TextBox1.Text = "38" Then
            TextBox3.Text = "+2 Ogre Power Gloves Of Thorn Guard"
        ElseIf TextBox1.Text = "39" Then
            TextBox3.Text = "+2 Dexterous Boots Of Indimitation"
        ElseIf TextBox1.Text = "40" Then
            TextBox3.Text = "Wand Of Cure Moderate Wounds 55 Charges "
        ElseIf TextBox1.Text = "41" Then
            TextBox3.Text = "Underwater Breathing Ring"
        ElseIf TextBox1.Text = "42" Then
            TextBox3.Text = "+2 Diplomatic Belt "
        ElseIf TextBox1.Text = "43" Then
            TextBox3.Text = "+2 Cloack Protection"
        ElseIf TextBox1.Text = "44" Then
            TextBox3.Text = "+2 Dagger"
        ElseIf TextBox1.Text = "45" Then
            TextBox3.Text = "+2 Falchion"
        ElseIf TextBox1.Text = "46" Then
            TextBox3.Text = "+2 Warhammer"
        ElseIf TextBox1.Text = "47" Then
            TextBox3.Text = "+2 Backstabbing Ring Of Protection"
        ElseIf TextBox1.Text = "48" Then
            TextBox3.Text = "+2 Shield Of Faith Ring Of Spell Resistance"
        ElseIf TextBox1.Text = "49" Then
            TextBox3.Text = "+2 Cloak Of Blasphemy"
        ElseIf TextBox1.Text = "50" Then
            TextBox3.Text = "+2 Scimitar Of Force Burst"
        ElseIf TextBox1.Text = "51" Then
            TextBox3.Text = "Spell Book Page "
        ElseIf TextBox1.Text = "52" Then
            TextBox3.Text = "Scroll Of Spell Scribe"
        ElseIf TextBox1.Text = "53" Then
            TextBox3.Text = "+2 Fearsome Helmet Of Concetration"
        ElseIf TextBox1.Text = "54" Then
            TextBox3.Text = "+2 Helmet Of Listening"
        ElseIf TextBox1.Text = "55" Then
            TextBox3.Text = "Diamond Fragment "
        ElseIf TextBox1.Text = "56" Then
            TextBox3.Text = "+2 Adamadine Breastplate Of Use Magic Device"
        ElseIf TextBox1.Text = "57" Then
            TextBox3.Text = "+2 Lucky Belt Of backstab"
        ElseIf TextBox1.Text = "58" Then
            TextBox3.Text = "+2 Belt Of Fire Resistance"
        ElseIf TextBox1.Text = "59" Then
            TextBox3.Text = "+2 Chaotic Greataxe"
        ElseIf TextBox1.Text = "60" Then
            TextBox3.Text = "+2 Scythe"
        ElseIf TextBox1.Text = "61" Then
            TextBox3.Text = "+2 5 Masterwork bolts"
        ElseIf TextBox1.Text = "62" Then
            TextBox3.Text = "+2 Studdet Leather Armour Of Stabilize"
        ElseIf TextBox1.Text = "63" Then
            TextBox3.Text = "Darksteel Greatsword"
        ElseIf TextBox1.Text = "64" Then
            TextBox3.Text = "Ring Of Vampiric Touch"
        ElseIf TextBox1.Text = "65" Then
            TextBox3.Text = "+2 Venomous Dagger Of wounding"
        ElseIf TextBox1.Text = "66" Then
            TextBox3.Text = "Vial Of Angel Kiss Poison"
        ElseIf TextBox1.Text = "67" Then
            TextBox3.Text = "+2 Backler Of Undead Guard"
        ElseIf TextBox1.Text = "68" Then
            TextBox3.Text = "+2 Scale Mail Of Frost Resistance"
        ElseIf TextBox1.Text = "69" Then
            TextBox3.Text = "+2 Protection Ring Of Poison Proof"
        ElseIf TextBox1.Text = "70" Then
            TextBox3.Text = "+2 Leather Armour Of Stadyness"
        ElseIf TextBox1.Text = "71" Then
            TextBox3.Text = "+2 Wise Belt Of Disease Proof"
        ElseIf TextBox1.Text = "72" Then
            TextBox3.Text = "+2 Crippling Halfplate Of Circle Against Evil"
        ElseIf TextBox1.Text = "73" Then
            TextBox3.Text = "Potion Of Enlarge Person"
        ElseIf TextBox1.Text = "74" Then
            TextBox3.Text = "Potion Of Invurnerabillity"
        ElseIf TextBox1.Text = "75" Then
            TextBox3.Text = "+2 Bodyfeeding Handaxe Of Flame"
        ElseIf TextBox1.Text = "76" Then
            TextBox3.Text = "+2 Bodyfeeding Greataxe Of Chaos"
        ElseIf TextBox1.Text = "77" Then
            TextBox3.Text = "Cats Grace Potion"
        ElseIf TextBox1.Text = "78" Then
            TextBox3.Text = "+2 Adamantine Battle Axe Of Missfortune"
        ElseIf TextBox1.Text = "79" Then
            TextBox3.Text = "+2 Combosite Longbow Of Shock"
        ElseIf TextBox1.Text = "80" Then
            TextBox3.Text = "Ring Of Low Light Vision"
        ElseIf TextBox1.Text = "81" Then
            TextBox3.Text = "+2 Wounding Kama Of Poison"
        ElseIf TextBox1.Text = "82" Then
            TextBox3.Text = "+2 Unholy Bastardsword"
        ElseIf TextBox1.Text = "83" Then
            TextBox3.Text = "+2 Acidic Keen Double Orc Axe"
        ElseIf TextBox1.Text = "84" Then
            TextBox3.Text = "+2 Goblin Bane Warhammer Of Crippling"
        ElseIf TextBox1.Text = "85" Then
            TextBox3.Text = "+2 Blade Boots Of Climbing"
        ElseIf TextBox1.Text = "86" Then
            TextBox3.Text = "+2 Flaming Heavy Mace Of Turning"
        ElseIf TextBox1.Text = "87" Then
            TextBox3.Text = "Robes Of Reduke Undead"
        ElseIf TextBox1.Text = "88" Then
            TextBox3.Text = "+3 False Life Breastplate Of Endurance "
        ElseIf TextBox1.Text = "89" Then
            TextBox3.Text = "+2 Lizardfolk Bane Lance"
        ElseIf TextBox1.Text = "90" Then
            TextBox3.Text = "+2 Force Composite Longbow Of Luck"
        ElseIf TextBox1.Text = "91" Then
            TextBox3.Text = "+2 Flaming Rapier Of Bodyfeeding"
        ElseIf TextBox1.Text = "92" Then
            TextBox3.Text = "+2 Heavy Crossbow"
        ElseIf TextBox1.Text = "93" Then
            TextBox3.Text = "+2 Shock Repeating Crossbow "
        ElseIf TextBox1.Text = "94" Then
            TextBox3.Text = "+2 Dwarven Urgorsh Od Sunder"
        ElseIf TextBox1.Text = "95" Then
            TextBox3.Text = "+2 Throwing Axe"
        ElseIf TextBox1.Text = "96" Then
            TextBox3.Text = "+2 Light Pick"
        ElseIf TextBox1.Text = "97" Then
            TextBox3.Text = "Remove Curse Potion"
        ElseIf TextBox1.Text = "98" Then
            TextBox3.Text = "Flame Tongue"
        ElseIf TextBox1.Text = "99" Then
            TextBox3.Text = "+2 Demon Bane Halbert Of Force "
        ElseIf TextBox1.Text = "100" Then
            TextBox3.Text = "+3 Flaming Scimitar Of Bane"

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text = "1" Then
            TextBox3.Text = "+3 Glaive Of Vampiric Touch"
        ElseIf TextBox1.Text = "2" Then
            TextBox3.Text = " +2 Kopesh Of Wounding"
        ElseIf TextBox1.Text = "3" Then
            TextBox3.Text = "+3 Lance Of Undead Bane "
        ElseIf TextBox1.Text = "4" Then
            TextBox3.Text = "+2 Holy Scimitar Of Bodyfeeding "
        ElseIf TextBox1.Text = "5" Then
            TextBox3.Text = "+3 Holy Flame Dwarven Waraxe "
        ElseIf TextBox1.Text = "6" Then
            TextBox3.Text = "+2 Fullplate Of Rage"
        ElseIf TextBox1.Text = "7" Then
            TextBox3.Text = "+3 Moderate Fortification Chainmail Of Acid Guard"
        ElseIf TextBox1.Text = "8" Then
            TextBox3.Text = "+2 Ring Of Cunning Indimitetion"
        ElseIf TextBox1.Text = "9" Then
            TextBox3.Text = "+3 Charismatic Ring"
        ElseIf TextBox1.Text = "10" Then
            TextBox3.Text = "Deck Of Many Things"
        ElseIf TextBox1.Text = "11" Then
            TextBox3.Text = "+2 Wounding Longsword Of Poison"
        ElseIf TextBox1.Text = "12" Then
            TextBox3.Text = "+3 Sai Of Backstabbing"
        ElseIf TextBox1.Text = "13" Then
            TextBox3.Text = "+2 Breastplate Of Barbaric Heritage "
        ElseIf TextBox1.Text = "14" Then
            TextBox3.Text = "+3 Flame Guard Fearsome FullPlate Of Deathblock "
        ElseIf TextBox1.Text = "15" Then
            TextBox3.Text = "+3 Fearsome Greatsword Of Sonic Burst"
        ElseIf TextBox1.Text = "16" Then
            TextBox3.Text = "+2 Keen Kopesh Of Holy Burst"
        ElseIf TextBox1.Text = "17" Then
            TextBox3.Text = "+2 Adamandine Towershield Of Acid Guard"
        ElseIf TextBox1.Text = "18" Then
            TextBox3.Text = "+3 Light Pick Of Paralizing"
        ElseIf TextBox1.Text = "19" Then
            TextBox3.Text = "+2 Stuff Of Pyrotechincs "
        ElseIf TextBox1.Text = "20" Then
            TextBox3.Text = "+3 Warhammer"
        ElseIf TextBox1.Text = "21" Then
            TextBox3.Text = "+2 Silent Leather Armour Of Hiding"
        ElseIf TextBox1.Text = "22" Then
            TextBox3.Text = "Potion Of Fox Cunning"
        ElseIf TextBox1.Text = "23" Then
            TextBox3.Text = "+3 Storm Greateaxe Of Sundering"
        ElseIf TextBox1.Text = "24" Then
            TextBox3.Text = "2540 PP Pouch"
        ElseIf TextBox1.Text = "25" Then
            TextBox3.Text = "+2 Oversized Towershield"
        ElseIf TextBox1.Text = "26" Then
            TextBox3.Text = "+2 Adamantine Longsword"
        ElseIf TextBox1.Text = "27" Then
            TextBox3.Text = "+3 16 Bolts Of Force"
        ElseIf TextBox1.Text = "28" Then
            TextBox3.Text = "+3 Charesmatic Belt Of Endurance"
        ElseIf TextBox1.Text = "29" Then
            TextBox3.Text = "+2 Dancing Bastardsword"
        ElseIf TextBox1.Text = "30" Then
            TextBox3.Text = "+3 Boots Of jump"
        ElseIf TextBox1.Text = "31" Then
            TextBox3.Text = "+2 Light Crossbow Of Flaming Burst"
        ElseIf TextBox1.Text = "32" Then
            TextBox3.Text = "+3 Dagger Of Assassinasion"
        ElseIf TextBox1.Text = "33" Then
            TextBox3.Text = "+2 Backler Of Acid Resistance"
        ElseIf TextBox1.Text = "34" Then
            TextBox3.Text = "+3 Seeking Greatsword Of Sonic"
        ElseIf TextBox1.Text = "35" Then
            TextBox3.Text = "+2 Dwarven Urgorsh Of The Thunderstorm"
        ElseIf TextBox1.Text = "36" Then
            TextBox3.Text = "+3 Seeker Javelin Of Return"
        ElseIf TextBox1.Text = "37" Then
            TextBox3.Text = "+2 Throwing Axe Of Poison "
        ElseIf TextBox1.Text = "38" Then
            TextBox3.Text = "+3 Ogre Power Gloves Of Thorn Guard"
        ElseIf TextBox1.Text = "39" Then
            TextBox3.Text = "+2 Speed Boots Of Indimitation"
        ElseIf TextBox1.Text = "40" Then
            TextBox3.Text = "Wand Of Cure Critical Wounds 55 Charges "
        ElseIf TextBox1.Text = "41" Then
            TextBox3.Text = "20 Slaying Arrows"
        ElseIf TextBox1.Text = "42" Then
            TextBox3.Text = "+3 Diplomatic Belt Of Bluffing "
        ElseIf TextBox1.Text = "43" Then
            TextBox3.Text = "+2 Magic Resistance Neckless Of Invisibillity"
        ElseIf TextBox1.Text = "44" Then
            TextBox3.Text = "+3 Spiked Armour "
        ElseIf TextBox1.Text = "45" Then
            TextBox3.Text = "+2 Longbow Of Harmsting"
        ElseIf TextBox1.Text = "46" Then
            TextBox3.Text = "+3 Warhammer Of Stunning"
        ElseIf TextBox1.Text = "47" Then
            TextBox3.Text = "+2 Combosite Longbow Of Paralizing"
        ElseIf TextBox1.Text = "48" Then
            TextBox3.Text = "+3 Curse Spweing Greatsword "
        ElseIf TextBox1.Text = "49" Then
            TextBox3.Text = "+2 Ghosttouching Glaive Of Undead Bane"
        ElseIf TextBox1.Text = "50" Then
            TextBox3.Text = "+3 Defending Shordsword"
        ElseIf TextBox1.Text = "51" Then
            TextBox3.Text = "Spell Book Page "
        ElseIf TextBox1.Text = "52" Then
            TextBox3.Text = "Scroll Of Fireball"
        ElseIf TextBox1.Text = "53" Then
            TextBox3.Text = "+2 Axiomatic Kopesh Of Seeking "
        ElseIf TextBox1.Text = "54" Then
            TextBox3.Text = "+3 Greater Chaotic Trident "
        ElseIf TextBox1.Text = "55" Then
            TextBox3.Text = "Scroll Of Detect Magic "
        ElseIf TextBox1.Text = "56" Then
            TextBox3.Text = "+2 Mudmabe Dagger Of Bane"
        ElseIf TextBox1.Text = "57" Then
            TextBox3.Text = "+3 Lucky Belt Of Rage "
        ElseIf TextBox1.Text = "58" Then
            TextBox3.Text = "+2 Helmet Of Charisma"
        ElseIf TextBox1.Text = "59" Then
            TextBox3.Text = "+3 Phantom Shortbow Of Shock"
        ElseIf TextBox1.Text = "60" Then
            TextBox3.Text = "+2 Fire Scythe"
        ElseIf TextBox1.Text = "61" Then
            TextBox3.Text = "+3 Bluffing Ring Of Performance"
        ElseIf TextBox1.Text = "62" Then
            TextBox3.Text = "+2 Blade Boots Of Enlarge Person"
        ElseIf TextBox1.Text = "63" Then
            TextBox3.Text = "+3 Unholy Whip Of Madness"
        ElseIf TextBox1.Text = "64" Then
            TextBox3.Text = "Belt Of Improved False Life"
        ElseIf TextBox1.Text = "65" Then
            TextBox3.Text = "+2 Repeating Crossbow "
        ElseIf TextBox1.Text = "66" Then
            TextBox3.Text = "+3 Rapier"
        ElseIf TextBox1.Text = "67" Then
            TextBox3.Text = "+2 Sackle"
        ElseIf TextBox1.Text = "68" Then
            TextBox3.Text = "+3 Longsword"
        ElseIf TextBox1.Text = "69" Then
            TextBox3.Text = "+2 Ring Of Searching"
        ElseIf TextBox1.Text = "70" Then
            TextBox3.Text = "+3 Ring Of Spot"
        ElseIf TextBox1.Text = "71" Then
            TextBox3.Text = "+2 Heavy Repeating Crossbow"
        ElseIf TextBox1.Text = "72" Then
            TextBox3.Text = "+3 Heavy Shield "
        ElseIf TextBox1.Text = "73" Then
            TextBox3.Text = "Potion Of Enlarge Person"
        ElseIf TextBox1.Text = "74" Then
            TextBox3.Text = "Potion Of Invurnerabillity"
        ElseIf TextBox1.Text = "75" Then
            TextBox3.Text = "+2 Anarchic Lance"
        ElseIf TextBox1.Text = "76" Then
            TextBox3.Text = "+3 Greataxe Of Chaos"
        ElseIf TextBox1.Text = "77" Then
            TextBox3.Text = "+2 Dagger of Cats Grace "
        ElseIf TextBox1.Text = "78" Then
            TextBox3.Text = "+3 Sonic Burst Morningstar"
        ElseIf TextBox1.Text = "79" Then
            TextBox3.Text = "+2 Flail Of Acid"
        ElseIf TextBox1.Text = "80" Then
            TextBox3.Text = "+3 Heavy Mace Of Bane"
        ElseIf TextBox1.Text = "81" Then
            TextBox3.Text = "+2 Mace Of Sundering "
        ElseIf TextBox1.Text = "82" Then
            TextBox3.Text = "+3 Light Pick Of the Gnome"
        ElseIf TextBox1.Text = "83" Then
            TextBox3.Text = "+2 Double Balde Sword"
        ElseIf TextBox1.Text = "84" Then
            TextBox3.Text = "+3 Goblin Bane Warhammer Of Crippling"
        ElseIf TextBox1.Text = "85" Then
            TextBox3.Text = "Scroll Of Animate Undead"
        ElseIf TextBox1.Text = "86" Then
            TextBox3.Text = "Scroll Of Cure Light Wounds"
        ElseIf TextBox1.Text = "87" Then
            TextBox3.Text = "+2 Silver Greateaxe "
        ElseIf TextBox1.Text = "88" Then
            TextBox3.Text = "+3 False Life Breastplate Of Endurance "
        ElseIf TextBox1.Text = "89" Then
            TextBox3.Text = "+2 Elf Bane Heavy Pick"
        ElseIf TextBox1.Text = "90" Then
            TextBox3.Text = "+3 Vicious Longsword Of force Burst"
        ElseIf TextBox1.Text = "91" Then
            TextBox3.Text = "+2 Spiked Fullplate "
        ElseIf TextBox1.Text = "92" Then
            TextBox3.Text = "+3 Spiked Towershield"
        ElseIf TextBox1.Text = "93" Then
            TextBox3.Text = "+2 Light Shield Of Thorns "
        ElseIf TextBox1.Text = "94" Then
            TextBox3.Text = "+3 Sundering Trident Of Force"
        ElseIf TextBox1.Text = "95" Then
            TextBox3.Text = "+2 Flaming Throwing Dagger Of Returning"
        ElseIf TextBox1.Text = "96" Then
            TextBox3.Text = "+3 Vicious Hand Axe"
        ElseIf TextBox1.Text = "97" Then
            TextBox3.Text = "Remove Curse Potion"
        ElseIf TextBox1.Text = "98" Then
            TextBox3.Text = "+2 Holy Burst Kama "
        ElseIf TextBox1.Text = "99" Then
            TextBox3.Text = "Maelstorm "
        ElseIf TextBox1.Text = "100" Then
            TextBox3.Text = "+3 Returning Arrow Of The Slayer"

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text = "1" Then
            TextBox3.Text = "+3 Enduring Belt Of Reflexes"
        ElseIf TextBox1.Text = "2" Then
            TextBox3.Text = " +4 Warhammer Of Undead Bane "
        ElseIf TextBox1.Text = "3" Then
            TextBox3.Text = "+4 Fullplate Of Elemental Resistance (Fire) "
        ElseIf TextBox1.Text = "4" Then
            TextBox3.Text = "+3 Boots Of Speed "
        ElseIf TextBox1.Text = "5" Then
            TextBox3.Text = "+4 Holy Flame Dwarven Waraxe Of Maiming "
        ElseIf TextBox1.Text = "6" Then
            TextBox3.Text = "+3 Spiked Breastplate Of Frightening Death Blocking "
        ElseIf TextBox1.Text = "7" Then
            TextBox3.Text = "+3 Dagger Of Force Burst"
        ElseIf TextBox1.Text = "8" Then
            TextBox3.Text = "+4 Greateaxe"
        ElseIf TextBox1.Text = "9" Then
            TextBox3.Text = "+3 Halbert"
        ElseIf TextBox1.Text = "10" Then
            TextBox3.Text = "Frost Resistance Potion"
        ElseIf TextBox1.Text = "11" Then
            TextBox3.Text = "+4 Belt Of Giant Strenght"
        ElseIf TextBox1.Text = "12" Then
            TextBox3.Text = "+3 Rope Dart Of Climbing"
        ElseIf TextBox1.Text = "13" Then
            TextBox3.Text = "+3 Light Crossbow Of Thunder  "
        ElseIf TextBox1.Text = "14" Then
            TextBox3.Text = "+3 Returning Dagger Of Accuracy "
        ElseIf TextBox1.Text = "15" Then
            TextBox3.Text = "+4 Charesmatic Ring"
        ElseIf TextBox1.Text = "16" Then
            TextBox3.Text = "+3 Vicious Falchion Of Harmsting"
        ElseIf TextBox1.Text = "17" Then
            TextBox3.Text = "+3 Adamatine Arrows (5)"
        ElseIf TextBox1.Text = "18" Then
            TextBox3.Text = "+3 Leather Armour"
        ElseIf TextBox1.Text = "19" Then
            TextBox3.Text = "+3 Chainshirt "
        ElseIf TextBox1.Text = "20" Then
            TextBox3.Text = "+4 Axiomatic Longsword Of Force Burst"
        ElseIf TextBox1.Text = "21" Then
            TextBox3.Text = "+3 Halfplate"
        ElseIf TextBox1.Text = "22" Then
            TextBox3.Text = "Potion Stone Skin"
        ElseIf TextBox1.Text = "23" Then
            TextBox3.Text = "+3 Heavy Crossbow Of Human Bane"
        ElseIf TextBox1.Text = "24" Then
            TextBox3.Text = "+3 Bone Bow "
        ElseIf TextBox1.Text = "25" Then
            TextBox3.Text = "+3 Flail"
        ElseIf TextBox1.Text = "26" Then
            TextBox3.Text = "+3 Spiked chain Of shock"
        ElseIf TextBox1.Text = "27" Then
            TextBox3.Text = "+3 Aid Kit"
        ElseIf TextBox1.Text = "28" Then
            TextBox3.Text = "+3 Dexterous Belt Of Searching"
        ElseIf TextBox1.Text = "29" Then
            TextBox3.Text = "+3 Shock Combosite Longbow Of Flaming Burst"
        ElseIf TextBox1.Text = "30" Then
            TextBox3.Text = "+3 Helmet Of Wisdom"
        ElseIf TextBox1.Text = "31" Then
            TextBox3.Text = "+4 Flaming Whip Of Vertigo"
        ElseIf TextBox1.Text = "32" Then
            TextBox3.Text = "+3 Sai Of Drow Bane"
        ElseIf TextBox1.Text = "33" Then
            TextBox3.Text = "+3 Giant Bane Scimitar Of Keen Edge"
        ElseIf TextBox1.Text = "34" Then
            TextBox3.Text = "+3 Diplomatic Cloak Of Indimitation"
        ElseIf TextBox1.Text = "35" Then
            TextBox3.Text = "+3 Bluffing Ring Of Performing"
        ElseIf TextBox1.Text = "36" Then
            TextBox3.Text = "+3 Healing Belt Of Lesser Fortification"
        ElseIf TextBox1.Text = "37" Then
            TextBox3.Text = "+3 Proof Against Poison Belt Of Bulls Strength "
        ElseIf TextBox1.Text = "38" Then
            TextBox3.Text = "+3 Heavy Shield Of Modarate Axeblock"
        ElseIf TextBox1.Text = "39" Then
            TextBox3.Text = "+3 Kobolt Bane Warhammer "
        ElseIf TextBox1.Text = "40" Then
            TextBox3.Text = "+3 Spell Resistance Boots Of Diplomacy "
        ElseIf TextBox1.Text = "41" Then
            TextBox3.Text = "+3 Scepter Of Spell Penetration"
        ElseIf TextBox1.Text = "42" Then
            TextBox3.Text = "+3 Light Footed Boots Of Hiding "
        ElseIf TextBox1.Text = "43" Then
            TextBox3.Text = "+3 Ring Of Ogre Power"
        ElseIf TextBox1.Text = "44" Then
            TextBox3.Text = "+3 Helmet Of Indimitation "
        ElseIf TextBox1.Text = "45" Then
            TextBox3.Text = "+4 Holy Greateaxe Of Vampire Bane "
        ElseIf TextBox1.Text = "46" Then
            TextBox3.Text = "+3 Light Pick Of Thunderstorm"
        ElseIf TextBox1.Text = "47" Then
            TextBox3.Text = "+3 Shocking Mace Of Body Feeding "
        ElseIf TextBox1.Text = "48" Then
            TextBox3.Text = "+4 Dancing Scimitar Of Keen Edge "
        ElseIf TextBox1.Text = "49" Then
            TextBox3.Text = "+3 Bluffing Ring Of Pick Lock "
        ElseIf TextBox1.Text = "50" Then
            TextBox3.Text = "+3 Defending Halbert Of Chaos"
        ElseIf TextBox1.Text = "51" Then
            TextBox3.Text = "Potion Of Cure Poison "
        ElseIf TextBox1.Text = "52" Then
            TextBox3.Text = "Potion Of Tumbling"
        ElseIf TextBox1.Text = "53" Then
            TextBox3.Text = "+3 Heavy Double Orc Axe  "
        ElseIf TextBox1.Text = "54" Then
            TextBox3.Text = "+3 Dire Flail Of Frost Burst "
        ElseIf TextBox1.Text = "55" Then
            TextBox3.Text = "+3 Flaming Kama Of Wounding "
        ElseIf TextBox1.Text = "56" Then
            TextBox3.Text = "+3 Shocking Morningstar "
        ElseIf TextBox1.Text = "57" Then
            TextBox3.Text = "+3 Force Kukri Of Luck "
        ElseIf TextBox1.Text = "58" Then
            TextBox3.Text = "+3 Sickle Of Animal Bane"
        ElseIf TextBox1.Text = "59" Then
            TextBox3.Text = "+3 Splint Armour Of Force Guard"
        ElseIf TextBox1.Text = "60" Then
            TextBox3.Text = "+3 Death Block Branded Mail"
        ElseIf TextBox1.Text = "61" Then
            TextBox3.Text = "+3 Tower Shield Of Bashing "
        ElseIf TextBox1.Text = "62" Then
            TextBox3.Text = "+3 Shock Javelin Of Sonic Burst"
        ElseIf TextBox1.Text = "63" Then
            TextBox3.Text = "+3 Great Club Of Harmsting"
        ElseIf TextBox1.Text = "64" Then
            TextBox3.Text = "+3 Force HandAxe Of Wounding "
        ElseIf TextBox1.Text = "65" Then
            TextBox3.Text = "+3 Light Repeating Crossbow Of Force "
        ElseIf TextBox1.Text = "66" Then
            TextBox3.Text = "+3 Poison Falchion Of Vertigo "
        ElseIf TextBox1.Text = "67" Then
            TextBox3.Text = "+3 Frost BattleAxe "
        ElseIf TextBox1.Text = "68" Then
            TextBox3.Text = "+3 Light Mace Of Sundering"
        ElseIf TextBox1.Text = "69" Then
            TextBox3.Text = "+3 Ring Of Consetration"
        ElseIf TextBox1.Text = "70" Then
            TextBox3.Text = "+3 Gathering Information Ring Of Spot"
        ElseIf TextBox1.Text = "71" Then
            TextBox3.Text = "+3 Heavy Repeating Crossbow Of Thundering"
        ElseIf TextBox1.Text = "72" Then
            TextBox3.Text = "+3 Nunchacku "
        ElseIf TextBox1.Text = "73" Then
            TextBox3.Text = "+3 Gnome Hooked Hammer Of Elf Bane"
        ElseIf TextBox1.Text = "74" Then
            TextBox3.Text = "+4 Shocking Dwarven Waraxe "
        ElseIf TextBox1.Text = "75" Then
            TextBox3.Text = "+3 Tumbling Boots Of Indimitation"
        ElseIf TextBox1.Text = "76" Then
            TextBox3.Text = "+3 Helmet Of Balance"
        ElseIf TextBox1.Text = "77" Then
            TextBox3.Text = "+3 Returning Dart Of Acid "
        ElseIf TextBox1.Text = "78" Then
            TextBox3.Text = "+3 Flaming Warhammer Of Axiomatic "
        ElseIf TextBox1.Text = "79" Then
            TextBox3.Text = "+3 Greatsword Of Acid"
        ElseIf TextBox1.Text = "80" Then
            TextBox3.Text = "+3 Punching Dagger Of Paralizing"
        ElseIf TextBox1.Text = "81" Then
            TextBox3.Text = "+3 Double Blade Sword Of Anarchy"
        ElseIf TextBox1.Text = "82" Then
            TextBox3.Text = "+3 Climbing Ring Of Bluffing "
        ElseIf TextBox1.Text = "83" Then
            TextBox3.Text = "+4 Acid Dagger Of Ghosttouch"
        ElseIf TextBox1.Text = "84" Then
            TextBox3.Text = "+3 Spiked Adamantine Fullplate Of Shock Guard"
        ElseIf TextBox1.Text = "85" Then
            TextBox3.Text = "Scroll Of Mayhem"
        ElseIf TextBox1.Text = "86" Then
            TextBox3.Text = "+3 Mithril Scale Mail Of Move Silently"
        ElseIf TextBox1.Text = "87" Then
            TextBox3.Text = "+3 Silver Dagger Of Warewolf Bane"
        ElseIf TextBox1.Text = "88" Then
            TextBox3.Text = "+3 False Life Breastplate Of Cunning "
        ElseIf TextBox1.Text = "89" Then
            TextBox3.Text = "+4 Elf Bane Heavy Pick"
        ElseIf TextBox1.Text = "90" Then
            TextBox3.Text = "+3 Vicious Handaxe Of force Burst"
        ElseIf TextBox1.Text = "91" Then
            TextBox3.Text = "+3 Bracers Of Natural Armour "
        ElseIf TextBox1.Text = "92" Then
            TextBox3.Text = "+4 Unholy Longsword Of Bane"
        ElseIf TextBox1.Text = "93" Then
            TextBox3.Text = "+3 Shocking Guard Chain Mail Of Moderate Fortification"
        ElseIf TextBox1.Text = "94" Then
            TextBox3.Text = "+4 Returning Chakram Of Holy Busrt "
        ElseIf TextBox1.Text = "95" Then
            TextBox3.Text = "+3 Flaming Great Crossbow Of Maiming"
        ElseIf TextBox1.Text = "96" Then
            TextBox3.Text = "+3 Flaming Vicious Falchion Of Flaming Burst"
        ElseIf TextBox1.Text = "97" Then
            TextBox3.Text = "+3 Spell Resistance Neckless Of Protection"
        ElseIf TextBox1.Text = "98" Then
            TextBox3.Text = "+4 Unholy Longsword Of Unholy Burst "
        ElseIf TextBox1.Text = "99" Then
            TextBox3.Text = "+3 Silver Flame Longsword Of Demon Bane "
        ElseIf TextBox1.Text = "100" Then
            TextBox3.Text = "Dragon Scale Mail Armour (Locked)"
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text = "1" Then
            TextBox3.Text = "Crystal Of Life Drinking"
        ElseIf TextBox1.Text = "2" Then
            TextBox3.Text = " Assassin's Whip  "
        ElseIf TextBox1.Text = "3" Then
            TextBox3.Text = "+4 Flame Guard Buckler Of Energy Immunity Of Fire"
        ElseIf TextBox1.Text = "4" Then
            TextBox3.Text = "+4 Aquan Longsword Or Auran "
        ElseIf TextBox1.Text = "5" Then
            TextBox3.Text = "+5 Blessed Heavy Mace Of Acid Burst "
        ElseIf TextBox1.Text = "6" Then
            TextBox3.Text = "+4 Longbow Of Sonic Burst"
        ElseIf TextBox1.Text = "7" Then
            TextBox3.Text = "+4 Greataxe Of Venom"
        ElseIf TextBox1.Text = "8" Then
            TextBox3.Text = "+5 Longsword Of Venom"
        ElseIf TextBox1.Text = "9" Then
            TextBox3.Text = "+5 Holy Flaming Bone Bow Of Holy Burst"
        ElseIf TextBox1.Text = "10" Then
            TextBox3.Text = "Potion Of Cure Serious Wounds"
        ElseIf TextBox1.Text = "11" Then
            TextBox3.Text = "Crystal Of Arcane Steel"
        ElseIf TextBox1.Text = "12" Then
            TextBox3.Text = "+4 Adamantine Spiked Full Plate Of Energy Immunity (Force)"
        ElseIf TextBox1.Text = "13" Then
            TextBox3.Text = "+4 Composite Longbow"
        ElseIf TextBox1.Text = "14" Then
            TextBox3.Text = "+4 Breastplate Of Healing "
        ElseIf TextBox1.Text = "15" Then
            TextBox3.Text = "+4 Ogre Power Leather Armour Of Sneaking"
        ElseIf TextBox1.Text = "16" Then
            TextBox3.Text = "+4 Ignan Spear Of Holy Surge"
        ElseIf TextBox1.Text = "17" Then
            TextBox3.Text = "+4 Metalline Bolts"
        ElseIf TextBox1.Text = "18" Then
            TextBox3.Text = "+4 Metalline Silver Falchion Of Knockback"
        ElseIf TextBox1.Text = "19" Then
            TextBox3.Text = "+4 Neckless Of Natural Armour "
        ElseIf TextBox1.Text = "20" Then
            TextBox3.Text = "+4 Necrotic Staff Of Wisdom"
        ElseIf TextBox1.Text = "21" Then
            TextBox3.Text = "+4 Profane Paralizing Longsword Of Holy Surge"
        ElseIf TextBox1.Text = "22" Then
            TextBox3.Text = "5587 PP Pouch"
        ElseIf TextBox1.Text = "23" Then
            TextBox3.Text = "+4 Quick Loading Light Crossbow"
        ElseIf TextBox1.Text = "24" Then
            TextBox3.Text = "Helmet Of Brilliance"
        ElseIf TextBox1.Text = "25" Then
            TextBox3.Text = "+4 Blessed Crusaders Fullplate Of Greater Healing"
        ElseIf TextBox1.Text = "26" Then
            TextBox3.Text = "+4 Radiant Leather Armour"
        ElseIf TextBox1.Text = "27" Then
            TextBox3.Text = "+4 Thives Tools"
        ElseIf TextBox1.Text = "28" Then
            TextBox3.Text = "+4 Protectors Ring Of Disguise"
        ElseIf TextBox1.Text = "29" Then
            TextBox3.Text = "+4 Ring Of Stamina"
        ElseIf TextBox1.Text = "30" Then
            TextBox3.Text = "+4 Greateaxe Of Bloodfeeding"
        ElseIf TextBox1.Text = "31" Then
            TextBox3.Text = "+4 Shocking Whip Of Vertigo"
        ElseIf TextBox1.Text = "32" Then
            TextBox3.Text = "+4 Dagger"
        ElseIf TextBox1.Text = "33" Then
            TextBox3.Text = "+4 Towershiled"
        ElseIf TextBox1.Text = "34" Then
            TextBox3.Text = "+4 Bolas Of Force Burst"
        ElseIf TextBox1.Text = "35" Then
            TextBox3.Text = "+4 Vanishing Studded Leather Of Quickness"
        ElseIf TextBox1.Text = "36" Then
            TextBox3.Text = "+4 Keen Greatesword Of Luck"
        ElseIf TextBox1.Text = "37" Then
            TextBox3.Text = "+4 Wise Ring Of Featherfalling "
        ElseIf TextBox1.Text = "38" Then
            TextBox3.Text = "+4 katana "
        ElseIf TextBox1.Text = "39" Then
            TextBox3.Text = "+4 Light Shield Of detect Secret Doors "
        ElseIf TextBox1.Text = "40" Then
            TextBox3.Text = "+4 Axiomatic Dagger Of Maiming "
        ElseIf TextBox1.Text = "41" Then
            TextBox3.Text = "+4 Chaotic Handaxe Of Harmsting"
        ElseIf TextBox1.Text = "42" Then
            TextBox3.Text = "+4 Dragondoom Battleaxe Of Frostburst "
        ElseIf TextBox1.Text = "43" Then
            TextBox3.Text = "Bearskin Armour"
        ElseIf TextBox1.Text = "44" Then
            TextBox3.Text = "+4 Shiled Of Mercy "
        ElseIf TextBox1.Text = "45" Then
            TextBox3.Text = "+4 Metalline Greataxe Of Luck "
        ElseIf TextBox1.Text = "46" Then
            TextBox3.Text = "+4 Light Mace"
        ElseIf TextBox1.Text = "47" Then
            TextBox3.Text = "+5 Shortbow "
        ElseIf TextBox1.Text = "48" Then
            TextBox3.Text = "+4 Repeating Light Crossbow Of Harmsting "
        ElseIf TextBox1.Text = "49" Then
            TextBox3.Text = "+4 Slight Of Hands Ring Of Pick Lock "
        ElseIf TextBox1.Text = "50" Then
            TextBox3.Text = "+4 Defending Scimitar Of Sonicburst"
        ElseIf TextBox1.Text = "51" Then
            TextBox3.Text = "Diamond"
        ElseIf TextBox1.Text = "52" Then
            TextBox3.Text = "+4 Endurance Ring Of Rage "
        ElseIf TextBox1.Text = "53" Then
            TextBox3.Text = "+4 Cunning Neckless Of Consetration   "
        ElseIf TextBox1.Text = "54" Then
            TextBox3.Text = "+4 Keen Glaive  "
        ElseIf TextBox1.Text = "55" Then
            TextBox3.Text = "Crystal Of Aquatic Action "
        ElseIf TextBox1.Text = "56" Then
            TextBox3.Text = "+4 Unholy Longsword Of Drow"
        ElseIf TextBox1.Text = "57" Then
            TextBox3.Text = "+4 Flaming Halbert Of Vertigo"
        ElseIf TextBox1.Text = "58" Then
            TextBox3.Text = "+4 Shocking Sai Of Assassination"
        ElseIf TextBox1.Text = "59" Then
            TextBox3.Text = "+4 Neckless Of Protection"
        ElseIf TextBox1.Text = "60" Then
            TextBox3.Text = "+4 Acid Warhammer Of Stunning"
        ElseIf TextBox1.Text = "61" Then
            TextBox3.Text = "+4 Sonic Whip Of Tripping "
        ElseIf TextBox1.Text = "62" Then
            TextBox3.Text = "+4 Arrows Of Shock (2)"
        ElseIf TextBox1.Text = "63" Then
            TextBox3.Text = "+4 Leather Armour Of Protection From Good"
        ElseIf TextBox1.Text = "64" Then
            TextBox3.Text = "+4 Breastplate Of Elemental Immunity (Shock)"
        ElseIf TextBox1.Text = "65" Then
            TextBox3.Text = "Potion Of Eagle Splendour"
        ElseIf TextBox1.Text = "66" Then
            TextBox3.Text = "Potion Of Cure Disease "
        ElseIf TextBox1.Text = "67" Then
            TextBox3.Text = "+4 Brutal Strike Morningstar Of Blur Strike"
        ElseIf TextBox1.Text = "68" Then
            TextBox3.Text = "+4 Chanelling Spear Of Collision"
        ElseIf TextBox1.Text = "69" Then
            TextBox3.Text = "+4 Dexterous Ring Of Searching"
        ElseIf TextBox1.Text = "70" Then
            TextBox3.Text = "+4 Disarming Flail Of Sonic Burst"
        ElseIf TextBox1.Text = "71" Then
            TextBox3.Text = "+4 Dispelling Trident Of Bane"
        ElseIf TextBox1.Text = "72" Then
            TextBox3.Text = "+4 Flaming  Nunchacku Of Stunning "
        ElseIf TextBox1.Text = "73" Then
            TextBox3.Text = "+4 Towershield Of Bashing"
        ElseIf TextBox1.Text = "74" Then
            TextBox3.Text = "+4 Great Crossbow "
        ElseIf TextBox1.Text = "75" Then
            TextBox3.Text = "+4 Dragonhunter Bolts (5)"
        ElseIf TextBox1.Text = "76" Then
            TextBox3.Text = "+4 Fleshgrinding Falchion Of Keen Edge"
        ElseIf TextBox1.Text = "77" Then
            TextBox3.Text = "+4 Impact Light Hammer Of Acid"
        ElseIf TextBox1.Text = "78" Then
            TextBox3.Text = "+4 Mindfeeder Dwarven Waraxe Of Shocking Burst "
        ElseIf TextBox1.Text = "79" Then
            TextBox3.Text = "+4 Keen Rapier Of Blind"
        ElseIf TextBox1.Text = "80" Then
            TextBox3.Text = "+4 Defending Longsword Of Perrying"
        ElseIf TextBox1.Text = "81" Then
            TextBox3.Text = "+4 Anarchic Composite Longbow Of Poison"
        ElseIf TextBox1.Text = "82" Then
            TextBox3.Text = "+4 Ogre Power Ring Of Necromancy"
        ElseIf TextBox1.Text = "83" Then
            TextBox3.Text = "+4 Acid Falchion Of Ghosttouch"
        ElseIf TextBox1.Text = "84" Then
            TextBox3.Text = "+4 Screaming Shortsword Of Acid Burst"
        ElseIf TextBox1.Text = "85" Then
            TextBox3.Text = "Shaphire"
        ElseIf TextBox1.Text = "86" Then
            TextBox3.Text = "+4 Charesmatic Scale Armour Of Swimming"
        ElseIf TextBox1.Text = "87" Then
            TextBox3.Text = "+4 Sacred Hooked Hammer Of Revealing "
        ElseIf TextBox1.Text = "88" Then
            TextBox3.Text = "+5 Greater False Life Full Armour Of Fire Resistance"
        ElseIf TextBox1.Text = "89" Then
            TextBox3.Text = "+4 Gnome Bane Great Club"
        ElseIf TextBox1.Text = "90" Then
            TextBox3.Text = "+4 Composite Longbow Of Holy Busrt"
        ElseIf TextBox1.Text = "91" Then
            TextBox3.Text = "+4 Acidic Dagger Of Slow Burst"
        ElseIf TextBox1.Text = "92" Then
            TextBox3.Text = "+4 Slint Armour Of Moderate Thorn Guard"
        ElseIf TextBox1.Text = "93" Then
            TextBox3.Text = "+4 Dancing Greataxe Of Disarming"
        ElseIf TextBox1.Text = "94" Then
            TextBox3.Text = "+4 Shattermantle Sai Of Terran "
        ElseIf TextBox1.Text = "95" Then
            TextBox3.Text = "+5 Vampiric Longsword Of Flaming Burst"
        ElseIf TextBox1.Text = "96" Then
            TextBox3.Text = "+4 Acid Greataxe Of Acid Burst"
        ElseIf TextBox1.Text = "97" Then
            TextBox3.Text = "Axe Of Ancestral Virue"
        ElseIf TextBox1.Text = "98" Then
            TextBox3.Text = "+4 Scimitar Of Unholy Surge "
        ElseIf TextBox1.Text = "99" Then
            TextBox3.Text = "Bow Of The Wintermoon "
        ElseIf TextBox1.Text = "100" Then
            TextBox3.Text = "Armour Of the Fallen Leaves"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text = "1" Then
            TextBox3.Text = "+5 Sacred Burst Shadowstrike Shattermantle Dagger Of Weakening"
        ElseIf TextBox1.Text = "2" Then
            TextBox3.Text = " +5 Greater Fortification Fullplate Of Enegy "
        ElseIf TextBox1.Text = "3" Then
            TextBox3.Text = "Whipe Of Webs"
        ElseIf TextBox1.Text = "4" Then
            TextBox3.Text = "Holy Avenger "
        ElseIf TextBox1.Text = "5" Then
            TextBox3.Text = "Crystal Of Energy Assult "
        ElseIf TextBox1.Text = "6" Then
            TextBox3.Text = "Wand Of Mass Cure Moderate Wounds (50)"
        ElseIf TextBox1.Text = "7" Then
            TextBox3.Text = "Wand Of Mass Charm Person (20)"
        ElseIf TextBox1.Text = "8" Then
            TextBox3.Text = "+5 Vorpal Longsword"
        ElseIf TextBox1.Text = "9" Then
            TextBox3.Text = "+5 Flaming Warhammer "
        ElseIf TextBox1.Text = "10" Then
            TextBox3.Text = "+5 Proof Against Disease Belt Of Wisdom"
        ElseIf TextBox1.Text = "11" Then
            TextBox3.Text = "+5 Greatbow"
        ElseIf TextBox1.Text = "12" Then
            TextBox3.Text = "+4 Shortbow Of Fire Burst"
        ElseIf TextBox1.Text = "13" Then
            TextBox3.Text = "+4 Heavy Crossbow Of Venom  "
        ElseIf TextBox1.Text = "14" Then
            TextBox3.Text = "+4 Scalemail Of Balance "
        ElseIf TextBox1.Text = "15" Then
            TextBox3.Text = "+4 Neckless Of Spot "
        ElseIf TextBox1.Text = "16" Then
            TextBox3.Text = "+4 Frost Spear Of Maiming"
        ElseIf TextBox1.Text = "17" Then
            TextBox3.Text = "+4 Arrows Of Slaying"
        ElseIf TextBox1.Text = "18" Then
            TextBox3.Text = "+4 Silver Flame Morningstar"
        ElseIf TextBox1.Text = "19" Then
            TextBox3.Text = "+5 Spiked Fullplate Of Deathblock "
        ElseIf TextBox1.Text = "20" Then
            TextBox3.Text = "+4 Paralizing Returning Throwing Dagger"
        ElseIf TextBox1.Text = "21" Then
            TextBox3.Text = "+5 Kukri"
        ElseIf TextBox1.Text = "22" Then
            TextBox3.Text = "Money Pouch (The Generous DM will tell the amount. )"
        ElseIf TextBox1.Text = "23" Then
            TextBox3.Text = "+4 Composite Longbow Of Cursespewing"
        ElseIf TextBox1.Text = "24" Then
            TextBox3.Text = "+5 Dagger Of Wishing"
        ElseIf TextBox1.Text = "25" Then
            TextBox3.Text = "+4 Sacred Morningstar Of Holy Burst"
        ElseIf TextBox1.Text = "26" Then
            TextBox3.Text = "+5 Blood Knight's Armour"
        ElseIf TextBox1.Text = "27" Then
            TextBox3.Text = "+4 Ring Of Slight Of Hands"
        ElseIf TextBox1.Text = "28" Then
            TextBox3.Text = "+5 Splint Armour Of Endurance"
        ElseIf TextBox1.Text = "29" Then
            TextBox3.Text = "+4 Scepter Of Evocation Focus"
        ElseIf TextBox1.Text = "30" Then
            TextBox3.Text = "+5 Greater Fortification Leather Armour Of Wisdom"
        ElseIf TextBox1.Text = "31" Then
            TextBox3.Text = "+4 Soulbinding Ghosttouch Sythe Of Marmonizing"
        ElseIf TextBox1.Text = "32" Then
            TextBox3.Text = "+5 Rapier"
        ElseIf TextBox1.Text = "33" Then
            TextBox3.Text = "+4 Handaxe Of Shock"
        ElseIf TextBox1.Text = "34" Then
            TextBox3.Text = "+5 Vicious Greataxe Of Mayhem"
        ElseIf TextBox1.Text = "35" Then
            TextBox3.Text = "+4 Helmet Of Buffing"
        ElseIf TextBox1.Text = "36" Then
            TextBox3.Text = "+5 Flaming Whip Of Flaming Burst"
        ElseIf TextBox1.Text = "37" Then
            TextBox3.Text = "+4 Bolts Of Acid (10)"
        ElseIf TextBox1.Text = "38" Then
            TextBox3.Text = "+5 Throwing Axe"
        ElseIf TextBox1.Text = "39" Then
            TextBox3.Text = "+4 Towershield Of Stone Skin "
        ElseIf TextBox1.Text = "40" Then
            TextBox3.Text = "+5 Charesmatic Ring Of Performing  "
        ElseIf TextBox1.Text = "41" Then
            TextBox3.Text = "+4 Ogre Power Ring Of Indimitation"
        ElseIf TextBox1.Text = "42" Then
            TextBox3.Text = "+5 Unholy Greatsword "
        ElseIf TextBox1.Text = "43" Then
            TextBox3.Text = "+4 Adamantine Buckler"
        ElseIf TextBox1.Text = "44" Then
            TextBox3.Text = "+5 Shattermentle Fullplate"
        ElseIf TextBox1.Text = "45" Then
            TextBox3.Text = "+4 Acid Longbow Of Vertigo "
        ElseIf TextBox1.Text = "46" Then
            TextBox3.Text = "+5 Kopesh"
        ElseIf TextBox1.Text = "47" Then
            TextBox3.Text = "+4 Sythe Of Doom "
        ElseIf TextBox1.Text = "48" Then
            TextBox3.Text = "+5 Ring Of Force Protection "
        ElseIf TextBox1.Text = "49" Then
            TextBox3.Text = "+4 Composite Shortbow Of Luck "
        ElseIf TextBox1.Text = "50" Then
            TextBox3.Text = "+5 Dancing Scimitar Of Keen Edge"
        ElseIf TextBox1.Text = "51" Then
            TextBox3.Text = "+4 Breastplate Of Rage"
        ElseIf TextBox1.Text = "52" Then
            TextBox3.Text = "+5 Cunning Ring Of Heroism  "
        ElseIf TextBox1.Text = "53" Then
            TextBox3.Text = "+4 Blade Boots"
        ElseIf TextBox1.Text = "54" Then
            TextBox3.Text = "+5 Tumbling Boots Of Speed"
        ElseIf TextBox1.Text = "55" Then
            TextBox3.Text = "Potion Of Flesh To Stone "
        ElseIf TextBox1.Text = "56" Then
            TextBox3.Text = "+4 Seeker Greatbow"
        ElseIf TextBox1.Text = "57" Then
            TextBox3.Text = "+5 Dwarven Urgorsh Of Orc Bane"
        ElseIf TextBox1.Text = "58" Then
            TextBox3.Text = "+4 Whip Of Force Burst"
        ElseIf TextBox1.Text = "59" Then
            TextBox3.Text = "+4 Flaming Razor Chain Of Wounding"
        ElseIf TextBox1.Text = "60" Then
            TextBox3.Text = "+5 Anarchic Greataxe Of Brilliance"
        ElseIf TextBox1.Text = "61" Then
            TextBox3.Text = "+4 Fiercebane Handaxe Of Fleshgrinding"
        ElseIf TextBox1.Text = "62" Then
            TextBox3.Text = "+5 Throwing Dagger"
        ElseIf TextBox1.Text = "63" Then
            TextBox3.Text = "Pothion Of Cat's Grace"
        ElseIf TextBox1.Text = "64" Then
            TextBox3.Text = "+5 Helmet Of Natural Armour"
        ElseIf TextBox1.Text = "65" Then
            TextBox3.Text = "Wand Of Haste (60)"
        ElseIf TextBox1.Text = "66" Then
            TextBox3.Text = "Wand Of Stone To Flesh"
        ElseIf TextBox1.Text = "67" Then
            TextBox3.Text = "+4 Ghost Srtike Force Heavily Burst Falchion Of Maiming"
        ElseIf TextBox1.Text = "68" Then
            TextBox3.Text = "+5 Returning Dart Of Poison"
        ElseIf TextBox1.Text = "69" Then
            TextBox3.Text = "+4 Wounding Blade Boots Of Expideous Retreat"
        ElseIf TextBox1.Text = "70" Then
            TextBox3.Text = "+5 Dire Flail Of Vampiric Touch"
        ElseIf TextBox1.Text = "71" Then
            TextBox3.Text = "+4 Illusion Bane Hunting Impendance Rapier"
        ElseIf TextBox1.Text = "72" Then
            TextBox3.Text = "+5 Implacable Impaling Venomous Lance Of Harmsting"
        ElseIf TextBox1.Text = "73" Then
            TextBox3.Text = "+4 Mithril Scalemail Of Swimming"
        ElseIf TextBox1.Text = "74" Then
            TextBox3.Text = "+5 Illusion Theft Lucky Dagger Of Magebane Knockback"
        ElseIf TextBox1.Text = "75" Then
            TextBox3.Text = "+4 Suriken (50)"
        ElseIf TextBox1.Text = "76" Then
            TextBox3.Text = "+5 Adamantine Flail"
        ElseIf TextBox1.Text = "77" Then
            TextBox3.Text = "+4 Unholy Shortsword Of Blasphemy"
        ElseIf TextBox1.Text = "78" Then
            TextBox3.Text = "+5 Mighty Smithing Warhammer of Morphing Mindcrusher"
        ElseIf TextBox1.Text = "79" Then
            TextBox3.Text = "+4 Throwing Dart Of Shock (9)"
        ElseIf TextBox1.Text = "80" Then
            TextBox3.Text = "+5 Returning Power Storing Warhammer Of Stunning(Moradin's Class)"
        ElseIf TextBox1.Text = "81" Then
            TextBox3.Text = "+4 Light Hammer Of Harmsting"
        ElseIf TextBox1.Text = "82" Then
            TextBox3.Text = "+5 Blasphemous Longsword Of Bane (Unholy)"
        ElseIf TextBox1.Text = "83" Then
            TextBox3.Text = "+4 Frost Dagger Of Ghosttouch"
        ElseIf TextBox1.Text = "84" Then
            TextBox3.Text = "+5 Vicious Greatsword Of Wounding"
        ElseIf TextBox1.Text = "85" Then
            TextBox3.Text = "Amethist"
        ElseIf TextBox1.Text = "86" Then
            TextBox3.Text = "+4 Punch Dagger Of Shock"
        ElseIf TextBox1.Text = "87" Then
            TextBox3.Text = "+5 Glaive Of Vetrigo"
        ElseIf TextBox1.Text = "88" Then
            TextBox3.Text = "+4 Smiting Katana Of Sundering"
        ElseIf TextBox1.Text = "89" Then
            TextBox3.Text = "+5 Animal Bane Sickle"
        ElseIf TextBox1.Text = "90" Then
            TextBox3.Text = "+4 Light Repeating Crossbow Of Hunting"
        ElseIf TextBox1.Text = "91" Then
            TextBox3.Text = "+5 Ring Of Healing"
        ElseIf TextBox1.Text = "92" Then
            TextBox3.Text = "+4 Neckless Of Force Protection"
        ElseIf TextBox1.Text = "93" Then
            TextBox3.Text = "+5 Greataxe Of Vorpal"
        ElseIf TextBox1.Text = "94" Then
            TextBox3.Text = "+4 Sai Of Sound Burst"
        ElseIf TextBox1.Text = "95" Then
            TextBox3.Text = "+5 Bodyfeeder Staff Of Tripping"
        ElseIf TextBox1.Text = "96" Then
            TextBox3.Text = "+4 Flaming Falchion Of Anarchy"
        ElseIf TextBox1.Text = "97" Then
            TextBox3.Text = "Oath Bow"
        ElseIf TextBox1.Text = "98" Then
            TextBox3.Text = "+5 Vorpal Scimitar"
        ElseIf TextBox1.Text = "99" Then
            TextBox3.Text = "+5 Axiomatic Battleaxe Of Holy Burst"
        ElseIf TextBox1.Text = "100" Then
            TextBox3.Text = "Nine Lives Stealer"
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox1.Text = "1" Then
            TextBox3.Text = "Bloodcrier's Hammer"
        ElseIf TextBox1.Text = "2" Then
            TextBox3.Text = "Bones Of Li-Peng"
        ElseIf TextBox1.Text = "3" Then
            TextBox3.Text = "Bow Of The Black Archer"
        ElseIf TextBox1.Text = "4" Then
            TextBox3.Text = "Bright Evening Star"
        ElseIf TextBox1.Text = "5" Then
            TextBox3.Text = "Hammer Of Thunderbolts"
        ElseIf TextBox1.Text = "6" Then
            TextBox3.Text = "Sword Of Kas"
        ElseIf TextBox1.Text = "7" Then
            TextBox3.Text = "Puncturing Ice"
        ElseIf TextBox1.Text = "8" Then
            TextBox3.Text = "Bullybasher's Gaunlet"
        ElseIf TextBox1.Text = "9" Then
            TextBox3.Text = "Caladbolg"
        ElseIf TextBox1.Text = "10" Then
            TextBox3.Text = "Caput Mortuum"
        ElseIf TextBox1.Text = "11" Then
            TextBox3.Text = "Axe Of The Sea Reavers"
        ElseIf TextBox1.Text = "12" Then
            TextBox3.Text = "Bladed Crossbow"
        ElseIf TextBox1.Text = "13" Then
            TextBox3.Text = "Coral's Bite"
        ElseIf TextBox1.Text = "14" Then
            TextBox3.Text = "Crimson Ruination"
        ElseIf TextBox1.Text = "15" Then
            TextBox3.Text = "Desert Wind"
        ElseIf TextBox1.Text = "16" Then
            TextBox3.Text = "Crystal Echoblade"
        ElseIf TextBox1.Text = "17" Then
            TextBox3.Text = "Blazing Skylance"
        ElseIf TextBox1.Text = "18" Then
            TextBox3.Text = "Assassin Whip"
        ElseIf TextBox1.Text = "19" Then
            TextBox3.Text = "Devious"
        ElseIf TextBox1.Text = "20" Then
            TextBox3.Text = "Vicious"
        ElseIf TextBox1.Text = "21" Then
            TextBox3.Text = "Divine Spark"
        ElseIf TextBox1.Text = "22" Then
            TextBox3.Text = "Dutindana"
        ElseIf TextBox1.Text = "23" Then
            TextBox3.Text = "Chain Of Obeisance"
        ElseIf TextBox1.Text = "24" Then
            TextBox3.Text = "Bowstaff"
        ElseIf TextBox1.Text = "25" Then
            TextBox3.Text = "Bow Of Songs"
        ElseIf TextBox1.Text = "26" Then
            TextBox3.Text = "Cubgel That Never Forgets"
        ElseIf TextBox1.Text = "27" Then
            TextBox3.Text = "Dymonheart"
        ElseIf TextBox1.Text = "28" Then
            TextBox3.Text = "Exordious"
        ElseIf TextBox1.Text = "29" Then
            TextBox3.Text = "Dagger Of Defiance"
        ElseIf TextBox1.Text = "30" Then
            TextBox3.Text = "Death Spike"
        ElseIf TextBox1.Text = "31" Then
            TextBox3.Text = "Gaunlet Of Gruumsh"
        ElseIf TextBox1.Text = "32" Then
            TextBox3.Text = "Fiendkiller's Flail"
        ElseIf TextBox1.Text = "33" Then
            TextBox3.Text = "Flay"
        ElseIf TextBox1.Text = "34" Then
            TextBox3.Text = "Frostburn's Wrath"
        ElseIf TextBox1.Text = "35" Then
            TextBox3.Text = "Full Moon's Trick"
        ElseIf TextBox1.Text = "36" Then
            TextBox3.Text = "Dwarf Crusher"
        ElseIf TextBox1.Text = "37" Then
            TextBox3.Text = "Explosive Sling"
        ElseIf TextBox1.Text = "38" Then
            TextBox3.Text = "The Fist"
        ElseIf TextBox1.Text = "39" Then
            TextBox3.Text = "Ghost Net"
        ElseIf TextBox1.Text = "40" Then
            TextBox3.Text = "Forceful Skylance"
        ElseIf TextBox1.Text = "41" Then
            TextBox3.Text = "Ghostfolly's Gloves"
        ElseIf TextBox1.Text = "42" Then
            TextBox3.Text = "Guurgal"
        ElseIf TextBox1.Text = "43" Then
            TextBox3.Text = "Hammer Of Witches"
        ElseIf TextBox1.Text = "44" Then
            TextBox3.Text = "Infiltrator"
        ElseIf TextBox1.Text = "45" Then
            TextBox3.Text = "Lorestealer"
        ElseIf TextBox1.Text = "46" Then
            TextBox3.Text = "Galeb Duhr Hammer"
        ElseIf TextBox1.Text = "47" Then
            TextBox3.Text = "Hoocked Hammer Of Hearthfire"
        ElseIf TextBox1.Text = "48" Then
            TextBox3.Text = "Manticore Gratesword"
        ElseIf TextBox1.Text = "49" Then
            TextBox3.Text = "Living Chain"
        ElseIf TextBox1.Text = "50" Then
            TextBox3.Text = "Mau-Jehe"
        ElseIf TextBox1.Text = "51" Then
            TextBox3.Text = "Lash Of Sands"
        ElseIf TextBox1.Text = "52" Then
            TextBox3.Text = "Mace Of The Dark Children"
        ElseIf TextBox1.Text = "53" Then
            TextBox3.Text = "Meteoric Knife"
        ElseIf TextBox1.Text = "54" Then
            TextBox3.Text = "Barricade Buckler"
        ElseIf TextBox1.Text = "55" Then
            TextBox3.Text = "Dragonrider Armour"
        ElseIf TextBox1.Text = "56" Then
            TextBox3.Text = "Dwanstar"
        ElseIf TextBox1.Text = "57" Then
            TextBox3.Text = "Mindsplitter"
        ElseIf TextBox1.Text = "58" Then
            TextBox3.Text = "Notched Spear"
        ElseIf TextBox1.Text = "59" Then
            TextBox3.Text = "Earthplate Armour"
        ElseIf TextBox1.Text = "60" Then
            TextBox3.Text = "Electric Eel Hide"
        ElseIf TextBox1.Text = "61" Then
            TextBox3.Text = "Planeshifters Knife"
        ElseIf TextBox1.Text = "62" Then
            TextBox3.Text = "Zombie Hide Armour"
        ElseIf TextBox1.Text = "63" Then
            TextBox3.Text = "Exoskeleton Armour"
        ElseIf TextBox1.Text = "64" Then
            TextBox3.Text = "Rod Of Trimeg"
        ElseIf TextBox1.Text = "65" Then
            TextBox3.Text = "Scales Of Balance"
        ElseIf TextBox1.Text = "66" Then
            TextBox3.Text = "Scarab Of Arabros"
        ElseIf TextBox1.Text = "67" Then
            TextBox3.Text = "Vampire Hide Armour"
        ElseIf TextBox1.Text = "68" Then
            TextBox3.Text = "Ghoul Hide Armour"
        ElseIf TextBox1.Text = "69" Then
            TextBox3.Text = "Shishi-O"
        ElseIf TextBox1.Text = "70" Then
            TextBox3.Text = "Kyton Armour"
        ElseIf TextBox1.Text = "71" Then
            TextBox3.Text = "Fox Hide Armour"
        ElseIf TextBox1.Text = "72" Then
            TextBox3.Text = "Simple Bow"
        ElseIf TextBox1.Text = "73" Then
            TextBox3.Text = "Skull Lash"
        ElseIf TextBox1.Text = "74" Then
            TextBox3.Text = "Millennial Chainmail"
        ElseIf TextBox1.Text = "75" Then
            TextBox3.Text = "Owlfeather Armour"
        ElseIf TextBox1.Text = "76" Then
            TextBox3.Text = "Mithralmist Shirt"
        ElseIf TextBox1.Text = "77" Then
            TextBox3.Text = "Morningstar Of The Many"
        ElseIf TextBox1.Text = "78" Then
            TextBox3.Text = "Pick Of Piercing"
        ElseIf TextBox1.Text = "79" Then
            TextBox3.Text = "Wight Armour"
        ElseIf TextBox1.Text = "80" Then
            TextBox3.Text = "Quarterstaff Of Battle"
        ElseIf TextBox1.Text = "81" Then
            TextBox3.Text = "Rapier Of Desperate Mesure"
        ElseIf TextBox1.Text = "82" Then
            TextBox3.Text = "Rapier Of Unnering Direction"
        ElseIf TextBox1.Text = "83" Then
            TextBox3.Text = "Rod Of Cat"
        ElseIf TextBox1.Text = "84" Then
            TextBox3.Text = "Rod Of Defiance"
        ElseIf TextBox1.Text = "85" Then
            TextBox3.Text = "Sling Of The Dire Wind"
        ElseIf TextBox1.Text = "86" Then
            TextBox3.Text = "Staff Of the Torrent Moons"
        ElseIf TextBox1.Text = "87" Then
            TextBox3.Text = "Shield Of The Resolute"
        ElseIf TextBox1.Text = "88" Then
            TextBox3.Text = "Bracers Of Power"
        ElseIf TextBox1.Text = "89" Then
            TextBox3.Text = "Shield Of The Severd Hand"
        ElseIf TextBox1.Text = "90" Then
            TextBox3.Text = "Wight Hide Shield"
        ElseIf TextBox1.Text = "91" Then
            TextBox3.Text = "Warpped Tower"
        ElseIf TextBox1.Text = "92" Then
            TextBox3.Text = "Stalker's Bow"
        ElseIf TextBox1.Text = "93" Then
            TextBox3.Text = "Steadfast"
        ElseIf TextBox1.Text = "94" Then
            TextBox3.Text = "Stormchaser's Cudgel"
        ElseIf TextBox1.Text = "95" Then
            TextBox3.Text = "Thanifex"
        ElseIf TextBox1.Text = "96" Then
            TextBox3.Text = "Treebrother"
        ElseIf TextBox1.Text = "97" Then
            TextBox3.Text = "Ur"
        ElseIf TextBox1.Text = "98" Then
            TextBox3.Text = "Wargird's Armour"
        ElseIf TextBox1.Text = "99" Then
            TextBox3.Text = "Scourge Of Pain"
        ElseIf TextBox1.Text = "100" Then
            TextBox3.Text = "Rogue Blade"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim random As Random
        Dim D20 As Integer
        random = New Random
        D20 = random.Next(1, 21)
        TextBox39.Text = D20

        Dim sum As Integer ' textbox 46 and 47
        Dim a As Integer
        Dim b As Integer
        sum = (a + b)

        a = Val(TextBox39.Text)
        b = Val(TextBox46.Text)
        sum = Val(TextBox46.Text) + Val(TextBox39.Text)
        TextBox47.Text = "The Roll Is " & a & " + " & b & " = " & sum & "."


    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim random As Random
        Dim D12 As Integer
        random = New Random
        D12 = random.Next(1, 13)
        TextBox40.Text = D12

        Dim sum As Integer ' 48 and 49 are the textboxes
        Dim a As Integer
        Dim b As Integer
        sum = (a + b)
        a = Val(TextBox40.Text)
        b = Val(TextBox48.Text)
        sum = Val(TextBox40.Text) + Val(TextBox48.Text)
        TextBox49.Text = "The Roll Is " & a & " + " & b & " = " & sum & "."
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim random As Random
        Dim D6 As Integer
        random = New Random
        D6 = random.Next(1, 7)
        TextBox41.Text = D6

        Dim sum As Integer ' textboxes 50 and 51
        Dim a As Integer
        Dim b As Integer
        sum = (a + b)
        a = Val(TextBox41.Text)
        b = Val(TextBox50.Text)
        sum = Val(TextBox50.Text) + Val(TextBox41.Text)
        TextBox51.Text = "The Roll Is " & a & " + " & b & " = " & sum & "."

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim random As Random
        Dim D8 As Integer
        random = New Random
        D8 = random.Next(1, 9)
        TextBox42.Text = D8

        Dim sum As Integer ' textboxes are 52 and 53
        Dim a As Integer
        Dim b As Integer
        sum = (a + b)
        a = Val(TextBox42.Text)
        b = Val(TextBox52.Text)
        sum = Val(TextBox42.Text) + Val(TextBox52.Text)
        TextBox53.Text = "The Roll Is " & a & " + " & b & " = " & sum & "."


    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim random As Random
        Dim D4 As Integer
        random = New Random
        D4 = random.Next(1, 5)
        TextBox43.Text = D4

        '54 55
        Dim sum As Integer
        Dim a As Integer
        Dim b As Integer
        sum = (a + b)
        a = Val(TextBox43.Text)
        b = Val(TextBox54.Text)
        sum = Val(TextBox54.Text) + Val(TextBox43.Text)
        TextBox55.Text = "The Roll Is " & a & " + " & b & " = " & sum & "."


    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim random As Random
        Dim D10 As Integer
        random = New Random
        D10 = random.Next(1, 11)
        TextBox44.Text = D10

        '56 and 57 are the textboxes
        Dim sum As Integer
        Dim a As Integer
        Dim b As Integer
        sum = (a + b)
        a = Val(TextBox44.Text)
        b = Val(TextBox56.Text)
        sum = Val(TextBox44.Text) + Val(TextBox56.Text)
        TextBox57.Text = "The Roll Is " & a & " + " & b & " = " & sum & "."

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim random As Random
        Dim D100 As Integer
        random = New Random
        D100 = random.Next(1, 101)
        TextBox45.Text = D100
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub LinkLabel9_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())

    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())

    End Sub

    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs) Handles GroupBox6.Enter

    End Sub

    Private Sub LinkLabel10_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub LinkLabel11_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel11.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        Me.Close()
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs) Handles DomainUpDown1.SelectedItemChanged

    End Sub

    Private Sub RichTextBox1_MouseLeave(sender As Object, e As EventArgs) Handles RichTextBox1.MouseLeave
        Label1.Text = ""
    End Sub
End Class
