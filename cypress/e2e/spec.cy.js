
describe('CalidadFinal', () => {
  it('IngresarCartas', () => {
    cy.visit(Cypress.env('base_url'))
    cy.get('#boton').click()
    cy.location('pathname').should('eq','/home/generar')
  })
  it('IngresarPrivacy', () => {
    cy.visit(Cypress.env('base_url'))
    cy.get('#privacy').click()
    cy.location('pathname').should('eq','/Home/Privacy')
  })
  it('IngresarPrivacyfooter', () => {
    cy.visit(Cypress.env('base_url'))
    cy.get('#privacy2').click()
    cy.location('pathname').should('eq','/Home/Privacy')
  })
})