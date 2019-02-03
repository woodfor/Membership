Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class Transaction
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=Transaction")
    End Sub

    Public Overridable Property Card As DbSet(Of Card)
    Public Overridable Property MemberType As DbSet(Of MemberType)
    Public Overridable Property P_PasswordType As DbSet(Of P_PasswordType)
    Public Overridable Property Store As DbSet(Of Store)
    Public Overridable Property Trans_purchase As DbSet(Of Trans_purchase)
    Public Overridable Property Trans_TopUp As DbSet(Of Trans_TopUp)
    Public Overridable Property Type As DbSet(Of Type)
    Public Overridable Property U_UserInfo As DbSet(Of U_UserInfo)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of Card)() _
            .Property(Function(e) e.card_id) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Card)() _
            .Property(Function(e) e.user_name) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Card)() _
            .Property(Function(e) e.open_id) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Card)() _
            .Property(Function(e) e.balance) _
            .HasPrecision(9, 2)

        modelBuilder.Entity(Of Card)() _
            .Property(Function(e) e.customer_phone) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Card)() _
            .Property(Function(e) e.number) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Card)() _
            .HasMany(Function(e) e.Trans_TopUp) _
            .WithRequired(Function(e) e.Card) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of Card)() _
            .HasMany(Function(e) e.Trans_purchase) _
            .WithRequired(Function(e) e.Card) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of MemberType)() _
            .Property(Function(e) e.name) _
            .IsUnicode(False)

        modelBuilder.Entity(Of MemberType)() _
            .Property(Function(e) e.discount) _
            .HasPrecision(4, 2)

        modelBuilder.Entity(Of MemberType)() _
            .HasMany(Function(e) e.Card) _
            .WithRequired(Function(e) e.MemberType) _
            .HasForeignKey(Function(e) e.type_id) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of P_PasswordType)() _
            .Property(Function(e) e.U_Name) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Store)() _
            .Property(Function(e) e.store_name) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Store)() _
            .Property(Function(e) e.city) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Store)() _
            .Property(Function(e) e.street) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Store)() _
            .Property(Function(e) e.admin_name) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Store)() _
            .Property(Function(e) e.admin_phone) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Store)() _
            .Property(Function(e) e.store_phone) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Store)() _
            .HasMany(Function(e) e.Card) _
            .WithRequired(Function(e) e.Store) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of Trans_purchase)() _
            .Property(Function(e) e.card_id) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Trans_purchase)() _
            .Property(Function(e) e.trans_money) _
            .HasPrecision(9, 2)

        modelBuilder.Entity(Of Trans_purchase)() _
            .Property(Function(e) e.discount) _
            .HasPrecision(4, 2)

        modelBuilder.Entity(Of Trans_TopUp)() _
            .Property(Function(e) e.card_id) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Trans_TopUp)() _
            .Property(Function(e) e.trans_money) _
            .HasPrecision(9, 2)

        modelBuilder.Entity(Of Trans_TopUp)() _
            .Property(Function(e) e.payer_name) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Trans_TopUp)() _
            .Property(Function(e) e.payer_phone) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Type)() _
            .Property(Function(e) e.name) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Type)() _
            .HasMany(Function(e) e.Trans_purchase) _
            .WithRequired(Function(e) e.Type) _
            .HasForeignKey(Function(e) e.type_id) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of U_UserInfo)() _
            .Property(Function(e) e.U_Name) _
            .IsUnicode(False)

        modelBuilder.Entity(Of U_UserInfo)() _
            .Property(Function(e) e.U_RelName) _
            .IsUnicode(False)

        modelBuilder.Entity(Of U_UserInfo)() _
            .Property(Function(e) e.U_PassWord) _
            .IsUnicode(False)

        modelBuilder.Entity(Of U_UserInfo)() _
            .Property(Function(e) e.U_PsdAnswer) _
            .IsUnicode(False)

        modelBuilder.Entity(Of U_UserInfo)() _
            .Property(Function(e) e.U_IdCard) _
            .IsUnicode(False)

        modelBuilder.Entity(Of U_UserInfo)() _
            .Property(Function(e) e.U_NativePlace) _
            .IsUnicode(False)

        modelBuilder.Entity(Of U_UserInfo)() _
            .Property(Function(e) e.U_Address) _
            .IsUnicode(False)

        modelBuilder.Entity(Of U_UserInfo)() _
            .Property(Function(e) e.U_Telephone) _
            .IsUnicode(False)

        modelBuilder.Entity(Of U_UserInfo)() _
            .Property(Function(e) e.U_Email) _
            .IsUnicode(False)

        modelBuilder.Entity(Of U_UserInfo)() _
            .Property(Function(e) e.U_PostalId) _
            .IsUnicode(False)

        modelBuilder.Entity(Of U_UserInfo)() _
            .Property(Function(e) e.U_wechat) _
            .IsUnicode(False)

        modelBuilder.Entity(Of U_UserInfo)() _
            .Property(Function(e) e.U_Position) _
            .IsUnicode(False)

        modelBuilder.Entity(Of U_UserInfo)() _
            .Property(Function(e) e.U_Reamrk) _
            .IsUnicode(False)

        modelBuilder.Entity(Of U_UserInfo)() _
            .HasMany(Function(e) e.Trans_purchase) _
            .WithRequired(Function(e) e.U_UserInfo) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of U_UserInfo)() _
            .HasMany(Function(e) e.Trans_TopUp) _
            .WithRequired(Function(e) e.U_UserInfo) _
            .WillCascadeOnDelete(False)
    End Sub
End Class
