using System;
using MeuEvento.Models;
using Microsoft.Maui.Controls;

namespace MeuEvento
{
    public partial class Cadastro : ContentPage
    {
        public Cadastro()
        {
            InitializeComponent();

            //colocar limitador para data incluida não ser anterior a hoje.
            dataInicioPicker.MinimumDate = DateTime.Now;
            //data termino ser pelo menos um dia apos o inicio.
            dataFimPicker.MinimumDate = dataInicioPicker.Date.AddDays(1);


        }
        //
        private void OnDataInicioChanged(object sender, DateChangedEventArgs e)
        {
            dataFimPicker.MinimumDate = dataInicioPicker.Date;
        }


        private async void OnSalvarClicked(object sender, EventArgs e)
        {

            try
            {
                Evento novoEvento = new Evento
                {
                    Nome = nomeEventoEntry.Text,
                   DataInicio = dataInicioPicker.Date,
                   DataFim = dataFimPicker.Date,
                   Participantes =int.Parse(participantesEntry.Text),
                   Local = localEntry.Text,
                   CustoPorParticipante = double.Parse(custoEntry.Text)


                };
                if (novoEvento.DataFim < novoEvento.DataInicio)
                {
                    await DisplayAlert("Erro", "A data de término não pode ser anterior à data de início!", "OK");
                    return;
                }

                await Navigation.PushAsync(new Resumo
                {
                    BindingContext = novoEvento
                });
            }
            catch (Exception)
            {
                await DisplayAlert("Erro", "Preencha todos os campos corretamente.", "OK");
            }
        }

        private void dataInicioPicker_DateSelected(object sender, DateChangedEventArgs e)
        {

        }
    }
}