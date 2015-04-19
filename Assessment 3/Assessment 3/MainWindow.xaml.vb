Class MainWindow 
    Dim objDb As New DatabaseManager
    Private Sub btnAddCustomer_Click(sender As Object, e As RoutedEventArgs) Handles btnAddCustomer.Click
        If txtCustID.Text = "" Or txtName.Text = "" Or txtAddress.Text = "" Or txtPhone.Text = "" Or txtDOB.Text = "" Then
            MsgBox("Please enter customer details.")
            Return
        End If

        objDb.AddCustomer(txtCustID.Text, txtName.Text, txtAddress.Text, txtPhone.Text, txtDOB.Text)
        MsgBox("User Successfully Added!")

        DGVCustomers.ItemsSource = objDb.CustomersList("%").DefaultView

        txtCustID.Text = ""
        txtName.Text = ""
        txtAddress.Text = ""
        txtPhone.Text = ""
        txtDOB.Text = ""
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        DGVCustomers.ItemsSource = objDb.CustomersList("%").DefaultView
        DGVMovies.ItemsSource = objDb.MovieList("%").DefaultView
        DGVRentals.ItemsSource = objDb.RentalList().DefaultView
    End Sub

    Private Sub btnDeleteCustomer_Click(sender As Object, e As RoutedEventArgs) Handles btnDeleteCustomer.Click
        If DGVCustomers.SelectedItem.Item(1) <> "" Then
            objDb.DeleteCustomer(DGVCustomers.SelectedItem.Item(0))
            DGVCustomers.ItemsSource = objDb.CustomersList("%").DefaultView

            MsgBox("User Details Successfully Updated!")
            DGVCustomers.ItemsSource = objDb.CustomersList("%").DefaultView
        End If
    End Sub

    Private Sub btnUpdateCustomer_Click(sender As Object, e As RoutedEventArgs) Handles btnUpdateCustomer.Click
        If DGVCustomers.SelectedItem.Item(2) <> "" Then
            objDb.UpdateCustomer(txtCustID.Text, txtAddress.Text, txtPhone.Text)

            DGVCustomers.ItemsSource = objDb.CustomersList("%").DefaultView
        End If
    End Sub

    Private Sub DGVCustomers_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles DGVCustomers.SelectionChanged
        Try
            txtCustID.Text = DGVCustomers.SelectedItem.Item(0)
            txtName.Text = DGVCustomers.SelectedItem.Item(1)
            txtAddress.Text = DGVCustomers.SelectedItem.Item(2)
            txtPhone.Text = DGVCustomers.SelectedItem.Item(3)
            txtDOB.Text = DGVCustomers.SelectedItem.Item(4)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAddMovie_Click(sender As Object, e As RoutedEventArgs) Handles btnAddMovie.Click
        If txtMovieID.Text Or txtTitle.Text Or txtGenre.Text Or txtRentalCost.Text Or txtReleaseDate.Text Then
            MsgBox("Please enter movie details.")
            Return
        End If

        objDb.AddMovie(txtMovieID.Text, txtTitle.Text, txtGenre.Text, txtRentalCost.Text, txtReleaseDate.Text)
        MsgBox("Movie Successfully Added!")

        DGVMovies.ItemsSource = objDb.MovieList("%").DefaultView

        txtMovieID.Text = ""
        txtTitle.Text = ""
        txtGenre.Text = ""
        txtRentalCost.Text = ""
        txtReleaseDate.Text = ""
    End Sub

    Private Sub btnDeleteMovie_Click(sender As Object, e As RoutedEventArgs) Handles btnDeleteMovie.Click
        If DGVMovies.SelectedItem.Item(1) <> "" Then
            objDb.DeleteMovie(DGVMovies.SelectedItem.Item(0))
            DGVMovies.ItemsSource = objDb.MovieList("%").DefaultView
        End If
    End Sub

    Private Sub DGVMovies_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles DGVMovies.SelectionChanged
        Try
            txtMovieID.Text = DGVMovies.SelectedItem.Item(0)
            txtTitle.Text = DGVMovies.SelectedItem.Item(1)
            txtGenre.Text = DGVMovies.SelectedItem.Item(2)
            txtRentalCost.Text = DGVMovies.SelectedItem.Item(3)
            txtReleaseDate.Text = DGVMovies.SelectedItem.Item(4)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUpdateMovie_Click(sender As Object, e As RoutedEventArgs) Handles btnUpdateMovie.Click
        If DGVMovies.SelectedItem.Item(1) <> "" Then
            objDb.UpdateMovie(txtMovieID.Text, txtGenre.Text, txtRentalCost.Text, txtReleaseDate.Text)

            DGVMovies.ItemsSource = objDb.MovieList("%").DefaultView
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As RoutedEventArgs) Handles btnReturn.Click
        objDb.ReturnMovie(Today, DGVRentals.SelectedItem.Item(0), DGVRentals.SelectedItem.Item(1))
        MsgBox("Movie Returned!")
        DGVRentals.ItemsSource = objDb.RentalList().DefaultView
        DGVMovies.ItemsSource = objDb.MovieList("%").DefaultView
    End Sub

    Private Sub btnIssue_Click(sender As Object, e As RoutedEventArgs) Handles btnIssue.Click
        If DGVMovies.SelectedItem.Item(5) = "OUT" Then
            MsgBox("Movie is already issued!")
            Return
        End If

        If DGVMovies.SelectedItem.Item(2) <> "" Then
            objDb.IssueMovie(DGVMovies.SelectedItem.Item(0), DGVCustomers.SelectedItem.Item(0))
        End If
        MsgBox("Movie Issued! ")
        DGVRentals.ItemsSource = objDb.RentalList().DefaultView
        DGVMovies.ItemsSource = objDb.MovieList("%").DefaultView
    End Sub

    Private Sub tbRented_Checked(sender As Object, e As RoutedEventArgs) Handles tbRented.Checked
        DGVRentals.ItemsSource = objDb.Rented().DefaultView
    End Sub

    Private Sub rbNotRented_Checked(sender As Object, e As RoutedEventArgs) Handles rbNotRented.Checked
        DGVRentals.ItemsSource = objDb.NotRented().DefaultView
    End Sub

    Private Sub txtCustID_GotFocus(sender As Object, e As RoutedEventArgs) Handles txtCustID.GotFocus
        txtCustID.Text = ""
    End Sub

    Private Sub txtName_GotFocus(sender As Object, e As RoutedEventArgs) Handles txtName.GotFocus
        txtName.Text = ""
    End Sub

    Private Sub txtAddress_GotFocus(sender As Object, e As RoutedEventArgs) Handles txtAddress.GotFocus
        txtAddress.Text = ""
    End Sub

    Private Sub txtDOB_GotFocus(sender As Object, e As RoutedEventArgs) Handles txtDOB.GotFocus
        txtDOB.Text = ""
    End Sub

    Private Sub txtGenre_GotFocus(sender As Object, e As RoutedEventArgs) Handles txtGenre.GotFocus
        txtGenre.Text = ""
    End Sub

    Private Sub txtReleaseDate_GotFocus(sender As Object, e As RoutedEventArgs) Handles txtReleaseDate.GotFocus
        txtReleaseDate.Text = ""
    End Sub

    Private Sub txtMovieID_GotFocus(sender As Object, e As RoutedEventArgs) Handles txtMovieID.GotFocus
        txtMovieID.Text = ""
    End Sub

    Private Sub txtTitle_GotFocus(sender As Object, e As RoutedEventArgs) Handles txtTitle.GotFocus
        txtTitle.Text = ""
    End Sub

    Private Sub txtPhone_GotFocus(sender As Object, e As RoutedEventArgs) Handles txtPhone.GotFocus
        txtPhone.Text = ""
    End Sub

    Private Sub txtRentalCost_GotFocus(sender As Object, e As RoutedEventArgs) Handles txtRentalCost.GotFocus
        txtRentalCost.Text = ""
    End Sub

    Private Sub txtCustID_PreviewTextInput(sender As Object, e As TextCompositionEventArgs) Handles txtCustID.PreviewTextInput
        If Not Char.IsDigit(CChar(e.Text)) Then e.Handled = True
    End Sub

    Private Sub txtMovieID_PreviewTextInput(sender As Object, e As TextCompositionEventArgs) Handles txtMovieID.PreviewTextInput
        If Not Char.IsDigit(CChar(e.Text)) Then e.Handled = True
    End Sub

    Private Sub txtName_PreviewTextInput(sender As Object, e As TextCompositionEventArgs) Handles txtName.PreviewTextInput
        If Char.IsDigit(CChar(e.Text)) Then e.Handled = True
    End Sub

    Private Sub txtTitle_PreviewTextInput(sender As Object, e As TextCompositionEventArgs) Handles txtTitle.PreviewTextInput
        If Char.IsDigit(CChar(e.Text)) Then e.Handled = True
    End Sub

    Private Sub txtPhone_PreviewTextInput(sender As Object, e As TextCompositionEventArgs) Handles txtPhone.PreviewTextInput
        If Not Char.IsDigit(CChar(e.Text)) Then e.Handled = True
    End Sub

    Private Sub txtRentalCost_PreviewTextInput(sender As Object, e As TextCompositionEventArgs) Handles txtRentalCost.PreviewTextInput
        If Not Char.IsDigit(CChar(e.Text)) Then e.Handled = True
    End Sub

    Private Sub txtGenre_PreviewTextInput(sender As Object, e As TextCompositionEventArgs) Handles txtGenre.PreviewTextInput
        If Char.IsDigit(CChar(e.Text)) Then e.Handled = True
    End Sub
End Class
