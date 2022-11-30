using DEMO_PROJET_07449.Business.Services;
using DEMO_PROJET_07449.DataAccess.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO_PROJET_07449.GUI.Views;
public partial class PatientMultiView : Form {
    private PatientDTO workingPatientDTO;
    private ViewIntent workingIntent;
    public PatientMultiView() {
        InitializeComponent();
    }


    public PatientDTO OpenWithIntent(PatientDTO patient, ViewIntent intent) {
        this.workingPatientDTO = patient;
        this.workingIntent = intent;
        switch (this.workingIntent) {
            case ViewIntent.CREATION:
                return this.OpenForCreation();
                break;
            case ViewIntent.MODIFICATION:
                return this.OpenForModification();
                break;
            case ViewIntent.DELETION:
                return this.OpenForDeletion();
                break;
            case ViewIntent.VISUALIZATION:
            default:
                return this.OpenForDisplay();
                break;
        }
    }

    protected PatientDTO OpenForCreation() {
        this.dateCreatedDTPicker.Enabled = false;
        this.lblTextId.Text = "";
        this.firstNameTextBox.Text = null;
        this.lastNameTextBox.Text = null;
        this.healthCardTextBox.Text = null;
        this.dateCreatedDTPicker.Value = DateTime.Now;
        this.actionButton.Text = "Create!";
        this.ShowDialog();
        return this.workingPatientDTO;
    }

    protected PatientDTO OpenForModification() {
        this.dateCreatedDTPicker.Enabled = false;
        this.lblTextId.Text = this.workingPatientDTO.Id.ToString();
        this.firstNameTextBox.Text = this.workingPatientDTO.FirstName;
        this.lastNameTextBox.Text = this.workingPatientDTO.LastName;
        this.healthCardTextBox.Text = this.workingPatientDTO.HealthCardNumber;
        this.dateCreatedDTPicker.Value = this.workingPatientDTO.CreatedDate;
        this.actionButton.Text = "Save Changes";
        this.ShowDialog();
        return this.workingPatientDTO;
    }

    protected PatientDTO OpenForDisplay() {
        this.firstNameTextBox.Enabled = false;
        this.lastNameTextBox.Enabled = false;
        this.healthCardTextBox.Enabled = false;
        this.dateCreatedDTPicker.Enabled = false;
        this.lblTextId.Text = this.workingPatientDTO.Id.ToString();
        this.firstNameTextBox.Text = this.workingPatientDTO.FirstName;
        this.lastNameTextBox.Text = this.workingPatientDTO.LastName;
        this.healthCardTextBox.Text = this.workingPatientDTO.HealthCardNumber;
        this.dateCreatedDTPicker.Value = this.workingPatientDTO.CreatedDate;
        this.actionButton.Text = "Close";
        this.ShowDialog();
        return this.workingPatientDTO;
    }

    protected PatientDTO OpenForDeletion() {
        this.firstNameTextBox.Enabled = false;
        this.lastNameTextBox.Enabled = false;
        this.healthCardTextBox.Enabled = false;
        this.dateCreatedDTPicker.Enabled = false;
        this.lblTextId.Text = this.workingPatientDTO.Id.ToString();
        this.firstNameTextBox.Text = this.workingPatientDTO.FirstName;
        this.lastNameTextBox.Text = this.workingPatientDTO.LastName;
        this.healthCardTextBox.Text = this.workingPatientDTO.HealthCardNumber;
        this.dateCreatedDTPicker.Value = this.workingPatientDTO.CreatedDate;
        this.actionButton.Text = "Delete";
        this.ShowDialog();
        return this.workingPatientDTO;
    }


    protected void TriggerDtoCreation() {
        // TODO: validation
        this.workingPatientDTO.FirstName = this.firstNameTextBox.Text;
        this.workingPatientDTO.LastName = this.lastNameTextBox.Text;
        this.workingPatientDTO.HealthCardNumber = this.healthCardTextBox.Text;
        MainService.GetInstance().GetPatientService().CreateNewPatient(this.workingPatientDTO);
        this.DialogResult = DialogResult.OK;
    }

    protected void TriggerDtoModification() {
        // TODO: validation
        this.workingPatientDTO.FirstName = this.firstNameTextBox.Text;
        this.workingPatientDTO.LastName = this.lastNameTextBox.Text;
        this.workingPatientDTO.HealthCardNumber = this.healthCardTextBox.Text;
        MainService.GetInstance().GetPatientService().SaveModifiedPatient(this.workingPatientDTO);
        this.DialogResult = DialogResult.OK;
    }

    protected void TriggerDtoDeletion() {
        // TODO: validation
        this.workingPatientDTO.FirstName = this.firstNameTextBox.Text;
        this.workingPatientDTO.LastName = this.lastNameTextBox.Text;
        this.workingPatientDTO.HealthCardNumber = this.healthCardTextBox.Text;
        MainService.GetInstance().GetPatientService().DeletePatient(this.workingPatientDTO);
        this.DialogResult = DialogResult.OK;
    }

    protected void CloseModalWindow() {
        this.DialogResult = DialogResult.OK;
    }

    private void actionButton_Click(object sender, EventArgs e) {
        switch (this.workingIntent) {
            case ViewIntent.CREATION:
                this.TriggerDtoCreation();
                break;
            case ViewIntent.MODIFICATION:
                this.TriggerDtoModification();
                break;
            case ViewIntent.DELETION:
                this.TriggerDtoDeletion();
                break;
            case ViewIntent.VISUALIZATION:
            default:
                this.CloseModalWindow();
                break;
        }
    }
}
