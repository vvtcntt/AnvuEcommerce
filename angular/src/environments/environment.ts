import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'AnvuEcommerce',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44333/',
    redirectUri: baseUrl,
    clientId: 'AnvuEcommerce_App',
    responseType: 'code',
    scope: 'offline_access AnvuEcommerce',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44339',
      rootNamespace: 'AnvuEcommerce',
    },
  },
} as Environment;
