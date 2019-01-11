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
    Public Overridable Property Store As DbSet(Of Store)
    Public Overridable Property Trans As DbSet(Of Trans)
    Public Overridable Property Worker As DbSet(Of Worker)

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
            .HasMany(Function(e) e.Trans) _
            .WithRequired(Function(e) e.Card) _
            .WillCascadeOnDelete(False)

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

        modelBuilder.Entity(Of Store)() _
            .HasMany(Function(e) e.Worker) _
            .WithRequired(Function(e) e.Store) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of Trans)() _
            .Property(Function(e) e.card_id) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Trans)() _
            .Property(Function(e) e.trans_money) _
            .HasPrecision(9, 2)

        modelBuilder.Entity(Of Trans)() _
            .Property(Function(e) e.payer_name) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Trans)() _
            .Property(Function(e) e.payer_phone) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Worker)() _
            .Property(Function(e) e.name) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Worker)() _
            .Property(Function(e) e.phone) _
            .IsFixedLength()

        modelBuilder.Entity(Of Worker)() _
            .HasMany(Function(e) e.Trans) _
            .WithRequired(Function(e) e.Worker) _
            .WillCascadeOnDelete(False)
    End Sub
End Class
