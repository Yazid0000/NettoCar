Imports System.Drawing
Imports System.Windows.Forms

Public Module StyleHelper

    ' Couleur principale bleue
    Public ReadOnly BleuPrincipal As Color = Color.FromArgb(30, 80, 162)
    Public ReadOnly BleuClair As Color = Color.FromArgb(200, 220, 255)
    Public ReadOnly RougeBtn As Color = Color.FromArgb(200, 40, 40)
    Public ReadOnly GrisBtn As Color = Color.FromArgb(100, 100, 100)
    Public ReadOnly FondFormulaire As Color = Color.FromArgb(245, 247, 252)

    ''' <summary>Applique le style bleu aux en-têtes du DataGridView.</summary>
    Public Sub StylerDGV(ByVal dgv As DataGridView)
        dgv.EnableHeadersVisualStyles = False
        dgv.ColumnHeadersDefaultCellStyle.BackColor = BleuPrincipal
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9.5!, FontStyle.Bold)
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv.ColumnHeadersHeight = 32
        dgv.GridColor = Color.FromArgb(210, 220, 240)
        dgv.BackgroundColor = Color.White
        dgv.BorderStyle = BorderStyle.None
        dgv.RowsDefaultCellStyle.BackColor = Color.White
        dgv.RowsDefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40)
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 241, 255)
        dgv.DefaultCellStyle.SelectionBackColor = BleuPrincipal
        dgv.DefaultCellStyle.SelectionForeColor = Color.White
        dgv.RowTemplate.Height = 28
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
    End Sub

    ''' <summary>Crée un bouton ToolStrip stylé bleu avec icône unicode.</summary>
    Public Function CreerBoutonToolStrip(ByVal icone As String, ByVal texte As String, ByVal couleur As Color) As ToolStripButton
        Dim btn As New ToolStripButton()
        btn.Text = icone & "  " & texte
        btn.Font = New Font("Microsoft Sans Serif", 9.5!, FontStyle.Bold)
        btn.ForeColor = Color.White
        btn.BackColor = couleur
        btn.DisplayStyle = ToolStripItemDisplayStyle.Text
        btn.AutoSize = True
        btn.Padding = New Padding(8, 4, 8, 4)
        Return btn
    End Function

    ''' <summary>Applique le style au label titre centré.</summary>
    Public Sub StylerTitre(ByVal lbl As Label, ByVal texte As String)
        lbl.Text = texte
        lbl.Font = New Font("Microsoft Sans Serif", 18.0!, FontStyle.Bold)
        lbl.ForeColor = Color.FromArgb(30, 50, 100)
        lbl.TextAlign = ContentAlignment.MiddleCenter
        lbl.Dock = DockStyle.Fill
    End Sub

    ''' <summary>Applique le style au label compteur.</summary>
    Public Sub StylerCompteur(ByVal lbl As Label, ByVal texte As String, ByVal nb As Integer)
        lbl.Text = texte & " : " & nb
        lbl.Font = New Font("Microsoft Sans Serif", 10.0!, FontStyle.Bold)
        lbl.ForeColor = BleuPrincipal
        lbl.TextAlign = ContentAlignment.MiddleCenter
        lbl.Dock = DockStyle.Fill
    End Sub


    ' ── Impression du contenu d'un DataGridView ───────────────
    Public Sub ImprimerDGV(ByVal dgv As System.Windows.Forms.DataGridView, ByVal titre As String)
        Dim pd As New System.Drawing.Printing.PrintDocument()
        pd.DefaultPageSettings.Landscape = True
        Dim pageIndex As Integer = 0
        Dim ligneIndex As Integer = 0
        Dim totalLignes As Integer = dgv.Rows.Count

        AddHandler pd.PrintPage, Sub(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs)
                                     Dim g As System.Drawing.Graphics = e.Graphics
                                     Dim yPos As Single = e.MarginBounds.Top
                                     Dim xPos As Single = e.MarginBounds.Left
                                     Dim pageWidth As Single = e.MarginBounds.Width

                                     ' ── Titre ──
                                     If pageIndex = 0 Then
                                         Dim fTitre As New System.Drawing.Font("Microsoft Sans Serif", 16, System.Drawing.FontStyle.Bold)
                                         Dim sizeTitre As System.Drawing.SizeF = g.MeasureString(titre, fTitre)
                                         g.DrawString(titre, fTitre, System.Drawing.Brushes.Navy,
                                                      xPos + (pageWidth - sizeTitre.Width) / 2, yPos)
                                         yPos += sizeTitre.Height + 10

                                         ' Ligne sous le titre
                                         g.DrawLine(System.Drawing.Pens.Navy, xPos, yPos, xPos + pageWidth, yPos)
                                         yPos += 15
                                     End If

                                     ' ── En-têtes colonnes ──
                                     Dim fHeader As New System.Drawing.Font("Microsoft Sans Serif", 9, System.Drawing.FontStyle.Bold)
                                     Dim fCell As New System.Drawing.Font("Microsoft Sans Serif", 9, System.Drawing.FontStyle.Regular)
                                     Dim rowH As Single = 22

                                     ' Calculer les largeurs proportionnelles de chaque colonne
                                     Dim totalDGVWidth As Single = 0
                                     For i As Integer = 0 To dgv.Columns.Count - 1
                                         If dgv.Columns(i).Visible Then totalDGVWidth += dgv.Columns(i).Width
                                     Next
                                     Dim colWidths(dgv.Columns.Count - 1) As Single
                                     For i As Integer = 0 To dgv.Columns.Count - 1
                                         colWidths(i) = If(dgv.Columns(i).Visible, (dgv.Columns(i).Width / totalDGVWidth) * pageWidth, 0)
                                     Next
                                     ' Calculer les positions X de départ de chaque colonne
                                     Dim colPositions(dgv.Columns.Count - 1) As Single
                                     colPositions(0) = xPos
                                     For i As Integer = 1 To dgv.Columns.Count - 1
                                         colPositions(i) = colPositions(i - 1) + colWidths(i - 1)
                                     Next

                                     If pageIndex = 0 OrElse ligneIndex = 0 Then
                                         Dim headerBrush As New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(30, 80, 162))
                                         g.FillRectangle(headerBrush, xPos, yPos, pageWidth, rowH)
                                         For i As Integer = 0 To dgv.Columns.Count - 1
                                             If dgv.Columns(i).Visible Then
                                                 Dim headerVal As String = dgv.Columns(i).HeaderText
                                                 Dim maxHWidth As Single = colWidths(i) - 6
                                                 If g.MeasureString(headerVal, fHeader).Width > maxHWidth Then
                                                     Do While headerVal.Length > 0 AndAlso g.MeasureString(headerVal & "...", fHeader).Width > maxHWidth
                                                         headerVal = headerVal.Substring(0, headerVal.Length - 1)
                                                     Loop
                                                     headerVal = headerVal & "..."
                                                 End If
                                                 g.DrawString(headerVal, fHeader, System.Drawing.Brushes.White,
                                                              colPositions(i) + 3, yPos + 4)
                                             End If
                                         Next
                                         yPos += rowH
                                     End If

                                     ' ── Lignes de données ──
                                     Dim altBrush As New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(240, 244, 252))
                                     Do While ligneIndex < totalLignes
                                         If yPos + rowH > e.MarginBounds.Bottom Then
                                             e.HasMorePages = True
                                             pageIndex += 1
                                             Exit Do
                                         End If
                                         ' Fond alterné
                                         If ligneIndex Mod 2 = 0 Then
                                             g.FillRectangle(altBrush, xPos, yPos, pageWidth, rowH)
                                         End If
                                         ' Cellules
                                         For i As Integer = 0 To dgv.Columns.Count - 1
                                             If dgv.Columns(i).Visible Then
                                                 Dim cellVal As String = ""
                                                 If dgv.Rows(ligneIndex).Cells(i).Value IsNot Nothing AndAlso
                                                    dgv.Rows(ligneIndex).Cells(i).Value IsNot DBNull.Value Then
                                                     cellVal = dgv.Rows(ligneIndex).Cells(i).Value.ToString()
                                                 End If
                                                 ' Tronquer le texte si trop long pour la colonne
                                                 Dim maxWidth As Single = colWidths(i) - 6
                                                 Dim cellSize As System.Drawing.SizeF = g.MeasureString(cellVal, fCell)
                                                 If cellSize.Width > maxWidth Then
                                                     Do While cellVal.Length > 0 AndAlso g.MeasureString(cellVal & "...", fCell).Width > maxWidth
                                                         cellVal = cellVal.Substring(0, cellVal.Length - 1)
                                                     Loop
                                                     cellVal = cellVal & "..."
                                                 End If
                                                 g.DrawString(cellVal, fCell, System.Drawing.Brushes.Black,
                                                              colPositions(i) + 3, yPos + 4)
                                             End If
                                         Next
                                         ' Ligne séparatrice
                                         g.DrawLine(System.Drawing.Pens.LightGray,
                                                    xPos, yPos + rowH, xPos + pageWidth, yPos + rowH)
                                         yPos += rowH
                                         ligneIndex += 1
                                     Loop

                                     ' Pied de page
                                     Dim fPied As New System.Drawing.Font("Microsoft Sans Serif", 8)
                                     g.DrawString("Imprimé le " & Date.Now.ToString("dd/MM/yyyy HH:mm"), fPied,
                                                  System.Drawing.Brushes.Gray,
                                                  xPos, e.MarginBounds.Bottom + 5)
                                     g.DrawString("Page " & (pageIndex + 1).ToString(), fPied,
                                                  System.Drawing.Brushes.Gray,
                                                  xPos + pageWidth - 50, e.MarginBounds.Bottom + 5)
                                 End Sub

        ' Aperçu avant impression
        Dim preview As New System.Windows.Forms.PrintPreviewDialog()
        preview.Document = pd
        preview.WindowState = System.Windows.Forms.FormWindowState.Maximized
        preview.ShowDialog()
    End Sub


    ' ═══════════════════════════════════════════════════════════
    '  Icônes dessinées en code pour le ToolStrip
    ' ═══════════════════════════════════════════════════════════

    Public Function IconeAjouter() As System.Drawing.Bitmap
        Dim bmp As New System.Drawing.Bitmap(24, 24)
        Using g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(bmp)
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            g.Clear(System.Drawing.Color.Transparent)
            ' Cercle vert
            Dim brush As New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(46, 160, 67))
            g.FillEllipse(brush, 1, 1, 22, 22)
            ' + blanc
            Dim pen As New System.Drawing.Pen(System.Drawing.Color.White, 3)
            g.DrawLine(pen, 12, 6, 12, 18)
            g.DrawLine(pen, 6, 12, 18, 12)
        End Using
        Return bmp
    End Function

    Public Function IconeModifier() As System.Drawing.Bitmap
        Dim bmp As New System.Drawing.Bitmap(24, 24)
        Using g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(bmp)
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            g.Clear(System.Drawing.Color.Transparent)
            ' Corps du crayon
            Dim pts() As System.Drawing.Point = {
                New System.Drawing.Point(5, 18),
                New System.Drawing.Point(8, 21),
                New System.Drawing.Point(20, 9),
                New System.Drawing.Point(17, 6)
            }
            g.FillPolygon(New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(230, 140, 0)), pts)
            g.DrawPolygon(New System.Drawing.Pen(System.Drawing.Color.FromArgb(180, 100, 0), 1), pts)
            ' Pointe
            Dim ptip() As System.Drawing.Point = {
                New System.Drawing.Point(2, 21),
                New System.Drawing.Point(5, 18),
                New System.Drawing.Point(8, 21)
            }
            g.FillPolygon(New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(255, 220, 150)), ptip)
            ' Haut du crayon
            Dim ptop() As System.Drawing.Point = {
                New System.Drawing.Point(17, 6),
                New System.Drawing.Point(20, 9),
                New System.Drawing.Point(22, 7),
                New System.Drawing.Point(19, 4)
            }
            g.FillPolygon(New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(200, 50, 50)), ptop)
        End Using
        Return bmp
    End Function

    Public Function IconeSupprimer() As System.Drawing.Bitmap
        Dim bmp As New System.Drawing.Bitmap(24, 24)
        Using g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(bmp)
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            g.Clear(System.Drawing.Color.Transparent)
            Dim rouge As New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(210, 40, 40))
            Dim rougeFonce As New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(160, 20, 20))
            ' Couvercle
            g.FillRectangle(rougeFonce, 4, 3, 16, 3)
            g.FillRectangle(rougeFonce, 9, 1, 6, 3)
            ' Corps poubelle
            g.FillRectangle(rouge, 5, 6, 14, 16)
            ' Lignes intérieures
            Dim pen As New System.Drawing.Pen(System.Drawing.Color.FromArgb(255, 100, 100), 1.5!)
            g.DrawLine(pen, 9, 9, 9, 19)
            g.DrawLine(pen, 12, 9, 12, 19)
            g.DrawLine(pen, 15, 9, 15, 19)
        End Using
        Return bmp
    End Function

    Public Function IconeActualiser() As System.Drawing.Bitmap
        Dim bmp As New System.Drawing.Bitmap(24, 24)
        Using g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(bmp)
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            g.Clear(System.Drawing.Color.Transparent)
            Dim pen As New System.Drawing.Pen(System.Drawing.Color.FromArgb(30, 120, 200), 3)
            ' Arc haut
            g.DrawArc(pen, 3, 3, 18, 18, 200, 280)
            ' Flèche haut
            Dim ptsH() As System.Drawing.Point = {
                New System.Drawing.Point(18, 3),
                New System.Drawing.Point(21, 9),
                New System.Drawing.Point(15, 9)
            }
            g.FillPolygon(New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(30, 120, 200)), ptsH)
        End Using
        Return bmp
    End Function

    Public Function IconeMenu() As System.Drawing.Bitmap
        Dim bmp As New System.Drawing.Bitmap(24, 24)
        Using g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(bmp)
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            g.Clear(System.Drawing.Color.Transparent)
            Dim bleu As New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(30, 80, 162))
            Dim bleuClair As New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(70, 130, 220))
            ' Toit
            Dim toit() As System.Drawing.Point = {
                New System.Drawing.Point(12, 2),
                New System.Drawing.Point(22, 11),
                New System.Drawing.Point(2, 11)
            }
            g.FillPolygon(bleu, toit)
            ' Murs
            g.FillRectangle(bleuClair, 4, 11, 16, 11)
            ' Porte
            g.FillRectangle(New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(20, 55, 120)), 9, 16, 6, 6)
        End Using
        Return bmp
    End Function

    Public Function IconeImprimer() As System.Drawing.Bitmap
        Dim bmp As New System.Drawing.Bitmap(24, 24)
        Using g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(bmp)
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            g.Clear(System.Drawing.Color.Transparent)
            Dim gris As New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(80, 90, 110))
            Dim blanc As New System.Drawing.SolidBrush(System.Drawing.Color.White)
            Dim bleu As New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(30, 80, 162))
            ' Corps imprimante
            g.FillRectangle(gris, 2, 8, 20, 10)
            ' Feuille sortante
            g.FillRectangle(blanc, 6, 12, 12, 8)
            g.DrawRectangle(New System.Drawing.Pen(System.Drawing.Color.LightGray, 1), 6, 12, 12, 8)
            ' Feuille entrante (en haut)
            g.FillRectangle(blanc, 7, 2, 10, 8)
            g.DrawRectangle(New System.Drawing.Pen(System.Drawing.Color.LightGray, 1), 7, 2, 10, 8)
            ' Voyant vert
            g.FillEllipse(New System.Drawing.SolidBrush(System.Drawing.Color.LimeGreen), 16, 11, 4, 4)
        End Using
        Return bmp
    End Function

    Public Function IconeRechercher() As System.Drawing.Bitmap
        Dim bmp As New System.Drawing.Bitmap(24, 24)
        Using g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(bmp)
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            g.Clear(System.Drawing.Color.Transparent)
            Dim pen As New System.Drawing.Pen(System.Drawing.Color.FromArgb(30, 80, 162), 3)
            ' Cercle loupe
            g.DrawEllipse(pen, 2, 2, 14, 14)
            ' Manche
            Dim penManche As New System.Drawing.Pen(System.Drawing.Color.FromArgb(30, 80, 162), 3.5!)
            penManche.StartCap = System.Drawing.Drawing2D.LineCap.Round
            penManche.EndCap = System.Drawing.Drawing2D.LineCap.Round
            g.DrawLine(penManche, 14, 14, 21, 21)
        End Using
        Return bmp
    End Function

    Public Function IconeMenuFichier() As System.Drawing.Bitmap
        Dim bmp As New System.Drawing.Bitmap(24, 24)
        Using g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(bmp)
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            g.Clear(System.Drawing.Color.Transparent)
            Dim blanc As New System.Drawing.SolidBrush(System.Drawing.Color.White)
            ' Toit (triangle)
            Dim toit() As System.Drawing.Point = {
                New System.Drawing.Point(12, 1),
                New System.Drawing.Point(23, 11),
                New System.Drawing.Point(1, 11)
            }
            g.FillPolygon(blanc, toit)
            ' Corps maison
            g.FillRectangle(blanc, 3, 11, 18, 12)
            ' Porte (trou dans le corps)
            Dim noir As New System.Drawing.SolidBrush(System.Drawing.Color.Transparent)
            g.FillRectangle(New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(30, 30, 30)), 9, 16, 6, 7)
            ' Cheminée
            g.FillRectangle(blanc, 4, 7, 3, 5)
        End Using
        Return bmp
    End Function

    Public Function IconeActualiserFichier() As System.Drawing.Bitmap
        Dim bmp As New System.Drawing.Bitmap(24, 24)
        Using g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(bmp)
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            g.Clear(System.Drawing.Color.Transparent)
            Dim pen As New System.Drawing.Pen(System.Drawing.Color.White, 3.0!)
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round
            ' Arc circulaire
            g.DrawArc(pen, 3, 3, 17, 17, 45, 270)
            ' Flèche en haut à droite
            Dim fleche() As System.Drawing.Point = {
                New System.Drawing.Point(17, 3),
                New System.Drawing.Point(21, 8),
                New System.Drawing.Point(13, 8)
            }
            g.FillPolygon(New System.Drawing.SolidBrush(System.Drawing.Color.White), fleche)
        End Using
        Return bmp
    End Function

    ' ── Applique les icônes à un ToolStrip ──────────────────────
    Public Sub AppliquerIcones(ByVal ts As System.Windows.Forms.ToolStrip)
        ts.ImageScalingSize = New System.Drawing.Size(24, 24)
        For Each item As System.Windows.Forms.ToolStripItem In ts.Items
            If TypeOf item Is System.Windows.Forms.ToolStripButton Then
                Dim btn As System.Windows.Forms.ToolStripButton = CType(item, System.Windows.Forms.ToolStripButton)
                btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
                btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
                btn.ImageTransparentColor = System.Drawing.Color.Transparent
                Select Case btn.Name
                    Case "btnAjouter" : btn.Image = IconeAjouter()
                    Case "btnModifier" : btn.Image = IconeModifier()
                    Case "btnSupprimer" : btn.Image = IconeSupprimer()
                    Case "btnActualiser"
                        btn.Image = New System.Drawing.Bitmap(Application.StartupPath & "\icones\actualiser.png")
                        btn.ImageTransparentColor = System.Drawing.Color.Magenta
                    Case "btnQuitter"
                        btn.Image = New System.Drawing.Bitmap(Application.StartupPath & "\icones\maison.png")
                        btn.ImageTransparentColor = System.Drawing.Color.Magenta
                    Case "btnImprimer" : btn.Image = IconeImprimer()
                End Select
            End If
        Next
        ' Icône loupe pour le label recherche
        For Each item As System.Windows.Forms.ToolStripItem In ts.Items
            If item.Name = "lblSearch" Then
                item.Image = IconeRechercher()
                item.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText
                item.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
                item.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            End If
        Next
    End Sub

End Module

' ================================================================
'  NettoCouleur — Renderer ToolStrip bleu pour tous les formulaires
' ================================================================
Public Class NettoCouleur
    Inherits ProfessionalColorTable

    Public Overrides ReadOnly Property ToolStripGradientBegin() As System.Drawing.Color
        Get
            Return System.Drawing.Color.FromArgb(30, 80, 162)
        End Get
    End Property

    Public Overrides ReadOnly Property ToolStripGradientMiddle() As System.Drawing.Color
        Get
            Return System.Drawing.Color.FromArgb(30, 80, 162)
        End Get
    End Property

    Public Overrides ReadOnly Property ToolStripGradientEnd() As System.Drawing.Color
        Get
            Return System.Drawing.Color.FromArgb(30, 80, 162)
        End Get
    End Property

    Public Overrides ReadOnly Property ButtonSelectedHighlight() As System.Drawing.Color
        Get
            Return System.Drawing.Color.FromArgb(60, 60, 60)
        End Get
    End Property

    Public Overrides ReadOnly Property ButtonSelectedHighlightBorder() As System.Drawing.Color
        Get
            Return System.Drawing.Color.FromArgb(60, 60, 60)
        End Get
    End Property

    Public Overrides ReadOnly Property ButtonPressedHighlight() As System.Drawing.Color
        Get
            Return System.Drawing.Color.FromArgb(45, 45, 45)
        End Get
    End Property

    Public Overrides ReadOnly Property ButtonSelectedGradientBegin() As System.Drawing.Color
        Get
            Return System.Drawing.Color.FromArgb(60, 60, 60)
        End Get
    End Property

    Public Overrides ReadOnly Property ButtonSelectedGradientMiddle() As System.Drawing.Color
        Get
            Return System.Drawing.Color.FromArgb(60, 60, 60)
        End Get
    End Property

    Public Overrides ReadOnly Property ButtonSelectedGradientEnd() As System.Drawing.Color
        Get
            Return System.Drawing.Color.FromArgb(60, 60, 60)
        End Get
    End Property

    Public Overrides ReadOnly Property ButtonPressedGradientBegin() As System.Drawing.Color
        Get
            Return System.Drawing.Color.FromArgb(45, 45, 45)
        End Get
    End Property

    Public Overrides ReadOnly Property ButtonPressedGradientMiddle() As System.Drawing.Color
        Get
            Return System.Drawing.Color.FromArgb(45, 45, 45)
        End Get
    End Property

    Public Overrides ReadOnly Property ButtonPressedGradientEnd() As System.Drawing.Color
        Get
            Return System.Drawing.Color.FromArgb(45, 45, 45)
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientBegin() As System.Drawing.Color
        Get
            Return System.Drawing.Color.FromArgb(30, 30, 30)
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientMiddle() As System.Drawing.Color
        Get
            Return System.Drawing.Color.FromArgb(30, 30, 30)
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientEnd() As System.Drawing.Color
        Get
            Return System.Drawing.Color.FromArgb(30, 30, 30)
        End Get
    End Property


    Public Overrides ReadOnly Property ButtonSelectedBorder() As System.Drawing.Color
        Get
            Return System.Drawing.Color.FromArgb(255, 255, 255)
        End Get
    End Property

    Public Overrides ReadOnly Property ButtonPressedBorder() As System.Drawing.Color
        Get
            Return System.Drawing.Color.FromArgb(255, 255, 255)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuBorder() As System.Drawing.Color
        Get
            Return System.Drawing.Color.FromArgb(255, 255, 255)
        End Get
    End Property

    Public Overrides ReadOnly Property ToolStripBorder() As System.Drawing.Color
        Get
            Return System.Drawing.Color.FromArgb(30, 30, 30)
        End Get
    End Property

    Public Overrides ReadOnly Property SeparatorDark() As System.Drawing.Color
        Get
            Return System.Drawing.Color.FromArgb(80, 80, 80)
        End Get
    End Property

    Public Overrides ReadOnly Property SeparatorLight() As System.Drawing.Color
        Get
            Return System.Drawing.Color.FromArgb(80, 80, 80)
        End Get
    End Property

End Class
